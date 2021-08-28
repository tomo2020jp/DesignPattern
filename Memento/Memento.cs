using System;
using System.Collections.Generic;

namespace Memento
{
    public class Memento
    {
        public int Money { get; }
        IList<string> fruits = new List<string>();
        public Memento(int money)
        {
            Money = money;
        }

        public void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        public IList<string> GetFruits()
        {
            return new List<string>(fruits);
        }
    }
}
