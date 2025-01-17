﻿using System.Collections.Generic;
using Hevadea.Entities.Monsters;
using Hevadea.Framework;
using Hevadea.Scenes.Menus;
using Hevadea.Tiles.Components;
using Hevadea.Utils;
using Microsoft.Xna.Framework;

namespace Hevadea.Entities.Components
{
    public class ComponentMove : EntityComponent
    {
        private int _moveTick;
        private const int MINIMUM_BETWEEN_COMBATS = 100;
        public bool IsMoving => _moveTick == Rise.MonoGame.Ticks || _moveTick == Rise.MonoGame.Ticks - 1;
        public bool NoClip { get; set; } = false;

        public void MoveTo(Coordinates tilePosition, float speed = 1f, bool setFacing = false)
        {
            var destination = tilePosition.GetCenter();

            MoveTo(destination.X, destination.Y, speed, setFacing);

        }

        public void MoveTo(float x, float y, float speed = 1f, bool setFacing = false)
        {
            var dir = new Vector2(x - Owner.X, y - Owner.Y);

            if (dir.Length() > 1f)
            {
                dir.Normalize();
                dir = dir * speed;
            }

            if (setFacing) Owner.Facing = dir.ToDirection();
            Do(dir.X, dir.Y);
        }

        public bool Do(float sx, float sy, Direction facing)
        {
            if (!Do(sx, sy)) return false;

            if (!(Owner.GetComponent<ComponentAttack>()?.IsAttacking ?? false)) Owner.Facing = facing;
            return true;
        }

        public bool Do(float sx, float sy)
        {
            if (Owner.Removed) return false;

            if (Owner.Level.GetTile(Owner.Coordinates).HasTag<GroundTile>())
            {
                var ground = Owner.Level.GetTile(Owner.Coordinates).Tag<GroundTile>();

                sx *= ground.MoveSpeed;
                sy *= ground.MoveSpeed;
            }

            // Stop the entity on world borders.
            if (Owner.X + sx >= Owner.Level.Width * Game.Unit) sx = 0;
            if (Owner.Y + sy >= Owner.Level.Height * Game.Unit) sy = 0;

            Coordinates coordinates = new Coordinates(Owner.Coordinates.X, Owner.Coordinates.Y);

            if (sx > 0) coordinates.X += 1;
            else if (sx < 0) coordinates.X -= 1;

            if (sy > 0) coordinates.Y += 1;
            else if (sy < 0) coordinates.Y -= 1;

            if (Owner.GetType() == typeof(Monster))
            {
                Monster m = (Monster)Owner;
                if (m.IsInCombat)
                {
                    sx = 0;
                    sy = 0;
                }
            }
            if (Owner.GetType() == typeof(Player))
            {
                Player p = (Player)Owner;
                if (p.IsInCombat)
                {
                    sx = 0;
                    sy = 0;
                }
            }
            if ((Owner.Identifier == "boat" && !Owner.Level.GetTile(coordinates).HasTag<LiquideTile>())
               || (Owner.Identifier == "fish" && !Owner.Level.GetTile(coordinates).HasTag<LiquideTile>()))
            {
                sx = 0;
                sy = 0;
            }
            if (Owner.Identifier == "fish" && sx > 0 && sy <= 0)
            {
                var coor = coordinates;
                coor.X += 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X -= 1;

                coor.X -= 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X += 1;
            }
            if (Owner.Identifier == "fish" && sx <= 0 && sy > 0)
            {
                var coor = coordinates;
                coor.Y += 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y -= 1;

                coor.Y -= 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y += 1;
            }
            if (Owner.Identifier == "fish" && sx > 0 && sy > 0)
            {
                var coor = coordinates;
                coor.X = coor.X + 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X--;
                coor.X = coor.X - 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X++;


                coor.Y--;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y++;
                coor.Y++;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y--;
            }
            if (Owner.Identifier == "fish" && sx < 0 && sy < 0)
            {
                var coor = coordinates;
                coor.X = coor.X - 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X++;
                coor.X = coor.X + 1;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sx = 0;
                coor.X--;


                coor.Y++;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y--;
                coor.Y--;
                if (!Owner.Level.GetTile(coor).HasTag<LiquideTile>())
                    sy = 0;
                coor.Y++;
            }

            if (Owner.X + sx < 0) sx = 0;
            if (Owner.Y + sy < 0) sy = 0;

            var level = Owner.Level;
            var ownerColider = Owner.GetComponent<ComponentCollider>();

            if (ownerColider != null)
            {
                var ownerhitbox = ownerColider.GetHitBox();
                var futurPositionX = new RectangleF(ownerhitbox.X + sx, ownerhitbox.Y, ownerhitbox.Width,
                    ownerhitbox.Height);
                var futurPositionY = new RectangleF(ownerhitbox.X, ownerhitbox.Y + sy, ownerhitbox.Width,
                    ownerhitbox.Height);

                var futurPosition = new RectangleF(ownerhitbox.X + sx, ownerhitbox.Y + sy, ownerhitbox.Width,
                    ownerhitbox.Height);

                var colidingEntity = new HashSet<Entity>();

                colidingEntity.UnionWith(level.QueryEntity(futurPosition));
                colidingEntity.UnionWith(level.QueryEntity(futurPositionX));
                colidingEntity.UnionWith(level.QueryEntity(futurPositionY));

                foreach (var e in colidingEntity)
                {
                    var eColider = e.GetComponent<ComponentCollider>();
                    if (e == Owner || !(eColider?.CanCollideWith(Owner) ?? false)) continue;

                    var eHitbox = eColider.GetHitBox();

                    if (Collision.Colliding(eHitbox.X, eHitbox.Y, eHitbox.Width, eHitbox.Height, ownerhitbox.X,
                        ownerhitbox.Y + sy, ownerhitbox.Width, ownerhitbox.Height))
                    {
                        if (e is Monster && Owner is Player && ((Player)Owner).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            Owner.GameState.CurrentMenu = new MenuAttaque(e, e.GameState);
                            //e.Remove();
                            //Owner.Remove();
                        }
                        else if (e is Player && Owner is Monster && ((Player)e).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            e.GameState.CurrentMenu = new MenuAttaque(Owner, e.GameState);
                            //e.Remove();
                            //Owner.Remove();
                        }
                        else
                        {
                            e.GetComponent<ComponentPushable>()?.Push(Owner, 0f, sy);
                            _moveTick = Rise.MonoGame.Ticks;
                        }
                    }

                    eHitbox = eColider.GetHitBox();
                    if (Collision.Colliding(eHitbox.X, eHitbox.Y, eHitbox.Width, eHitbox.Height, ownerhitbox.X,
                        ownerhitbox.Y + sy, ownerhitbox.Width, ownerhitbox.Height)) sy = 0;

                    if (Collision.Colliding(eHitbox.X, eHitbox.Y, eHitbox.Width, eHitbox.Height, ownerhitbox.X + sx,
                        ownerhitbox.Y, ownerhitbox.Width, ownerhitbox.Height))
                    {
                        if (e is AngryDog && Owner is Player && ((Player)Owner).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            Owner.GetComponent<ComponentHealth>().Hurt(e, 2.5f);
                        }
                        else if (e is Player && Owner is AngryDog && ((Player)e).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            e.GetComponent<ComponentHealth>().Hurt(e,2.5f);
                        }
                        if (e is Monster && Owner is Player && ((Player)Owner).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            Owner.GameState.CurrentMenu = new MenuAttaque(e, e.GameState);
                            //e.Remove();
                            //Owner.Remove();
                        }
                        else if (e is Player && Owner is Monster && ((Player)e).LastCombat > MINIMUM_BETWEEN_COMBATS)
                        {
                            e.GameState.CurrentMenu = new MenuAttaque(Owner, e.GameState);
                            //e.Remove();
                            //Owner.Remove();
                        }
                        else
                        {
                            e.GetComponent<ComponentPushable>()?.Push(Owner, sx, 0f);
                            _moveTick = Rise.MonoGame.Ticks;
                        }
                    }

                    eHitbox = eColider.GetHitBox();
                    if (Collision.Colliding(eHitbox.X, eHitbox.Y, eHitbox.Width, eHitbox.Height, ownerhitbox.X + sx,
                        ownerhitbox.Y, ownerhitbox.Width, ownerhitbox.Height)) sx = 0;
                }

                var entityTilePosition = Owner.Coordinates;

                for (var x = -1; x <= 1; x++)
                    for (var y = -1; y <= 1; y++)
                    {
                        var tile = new Coordinates(entityTilePosition.X + x, entityTilePosition.Y + y);
                        var isPassableTile = level.GetTile(tile).Tag<SolideTile>()?.CanPassThrought(Owner) ?? true;

                        if (!isPassableTile)
                        {
                            var tileRect = tile.ToRectangle();
                            if (Collision.Colliding(tileRect.X, tileRect.Y, tileRect.Width, tileRect.Height, ownerhitbox.X,
                                ownerhitbox.Y + sy, ownerhitbox.Width, ownerhitbox.Height)) sy = 0;
                            if (Collision.Colliding(tileRect.X, tileRect.Y, tileRect.Width, tileRect.Height,
                                ownerhitbox.X + sx, ownerhitbox.Y, ownerhitbox.Width, ownerhitbox.Height)) sx = 0;
                        }
                    }
            }

            if (sx != 0 || sy != 0)
            {
                Owner.SetPosition(Owner.X + sx, Owner.Y + sy);
                Owner.Level.GetTile(Owner.Coordinates).Tag<GroundTile>()?.SteppedOn(Owner, Owner.Coordinates);

                _moveTick = Rise.MonoGame.Ticks;
                return true;
            }

            return false;
        }
    }
}