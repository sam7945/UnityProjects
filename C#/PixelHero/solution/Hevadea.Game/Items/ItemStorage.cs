﻿using Hevadea.Registry;
using Hevadea.Tiles;
using Hevadea.Worlds;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hevadea.Items
{
    public class ItemStorage
    {
        //TODO: Modifier pour implémenter avec la BD (InventorySlots)
        public Dictionary<int, int> Items { get; set; }
        public int Capacity { get; }
        
        public ItemStorage(int capacity = 256)
        {
            Items = new Dictionary<int, int>();
            Capacity = capacity;
        }

        public int Add(Item item, int quantity)
        {
            if (item == null) return quantity;

            var count = quantity;
            for (var i = 0; i < quantity; i++)
                if (Add(item))
                    count--;

            return count;
        }

        public bool Add(Item item)
        {
            if (item == null || !HasFreeSlot()) return false;

            if (Items.ContainsKey(item.ItemId))
                Items[item.ItemId] = Items[item.ItemId] + 1;
            else
                Items.Add(item.ItemId, 1);

            return true;
        }

        public bool HasFreeSlot()
        {
            return Count() < Capacity;
        }

        public int Count()
        {
            var result = 0;

            foreach (var i in Items) result += i.Value;

            return result;
        }

        public int Count(Item item)
        {
            return item == null || !Items.ContainsKey(item.ItemId) ? 0 : Items[item.ItemId];
        }

        public int GetStackCount()
        {
            return Items.Count;
        }

        public Item GetStack(int index)
        {
            if (index >= Items.Count) return null;
            return ITEMS.ById[Items.Keys.ElementAt(index)];
        }

        public void Remove(Item item, int quantity)
        {
            if (item == null || !Items.ContainsKey(item.ItemId)) return;

            Items[item.ItemId] = Math.Max(Items[item.ItemId] - quantity, 0);

            if (Items[item.ItemId] == 0) Items.Remove(item.ItemId);
        }

        public int GetFreeSpace()
        {
            return Math.Max(0, Capacity - Count());
        }

        public void DropOnGround(Level level, float x, float y)
        {
            foreach (var i in Items) ITEMS.ById[i.Key].Drop(level, x, y, i.Value);

            Items.Clear();
        }

        public void DropOnGround(Level level, Item item, Coordinates pos, int count)
        {
            for (var i = 0; i < count; i++)
            {
                if (Count(item) <= 0) break;
                item.Drop(level, pos, 1);
                Remove(item, 1);
            }
        }
    }
}