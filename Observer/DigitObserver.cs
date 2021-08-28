using System;
using System.Threading;

namespace Observer
{
    public class DigitObserver : IMyObserver
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine($"DigitObserver:{generator.GetNumber()}");
            Thread.Sleep(100);
        }
    }
}
