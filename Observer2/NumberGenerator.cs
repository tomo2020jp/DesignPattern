using System;
using System.Collections.Generic;

namespace Observer2
{
    public abstract class NumberGenerator : IObservable<NumberGenerator>
    {
        private IList<IObserver<NumberGenerator>> observers = new List<IObserver<NumberGenerator>>();

        public IDisposable Subscribe(IObserver<NumberGenerator> observer)
        {
            observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void NotiffyObserver()
        {
            foreach (var i in observers)
            {
                i.OnNext(this);
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();

        private class Unsubscriber : IDisposable
        {
            private IList<IObserver<NumberGenerator>> observers;
            private IObserver<NumberGenerator> observer;

            public Unsubscriber(IList<IObserver<NumberGenerator>> observers, IObserver<NumberGenerator> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                observers.Remove(observer);
            }
        }
    }
}
