using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class NumberGenerator
    {
        private IList<IMyObserver> observers = new List<IMyObserver>();
        public void AddObserver(IMyObserver observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IMyObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotiffyObserver()
        {
            var it = observers.GetEnumerator();
            while (it.MoveNext())
            {
                it.Current.Update(this);
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();
    }
}
