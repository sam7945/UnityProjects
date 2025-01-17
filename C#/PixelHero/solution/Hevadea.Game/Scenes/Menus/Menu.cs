﻿using Hevadea.Framework;
using Hevadea.Framework.UI;
using Microsoft.Xna.Framework;

namespace Hevadea.Scenes.Menus
{
    public class Menu : WidgetPanel
    {
        public GameState GameState;
        public bool PauseGame { get; set; } = false;
        public bool EscapeToClose { get; set; } = false;
        public int ScreenHeight { get; set; }
        public int ScreenWidth { get; set; }
        public Menu _lastmenu;

        public Menu(GameState gameState)
        {
            GameState = gameState;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (Rise.Input.KeyTyped(Microsoft.Xna.Framework.Input.Keys.Escape) && EscapeToClose)
            {
                if (!(GameState.CurrentMenu is MenuAttaque))
                {
                    GameState.CurrentMenu = _lastmenu;
                }

                //GameState.CurrentMenu = new MenuInGame(GameState);
            }

        }
    }
}