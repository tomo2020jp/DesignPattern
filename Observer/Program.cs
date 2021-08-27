using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            IMyObserver observer1 = new DigitObserver();
            IMyObserver observer2 = new GraphObserver();
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.Execute();
        }
    }
}
