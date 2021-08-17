using System;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public abstract class Tray : Item
    {
        protected IList<Item> tray = new List<Item>();
        public Tray(string caption) : base(caption)
        { 
        }

        public void Add(Item item)
        {
            tray.Add(item);
        }
    }
}
