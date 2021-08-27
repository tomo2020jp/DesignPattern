using System;

namespace Observer2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            IObserver<NumberGenerator> observer1 = new DigitObserver();
            IObserver<NumberGenerator> observer2 = new GraphObserver();
            var disposable1 = generator.Subscribe(observer1);
            var disposable2 = generator.Subscribe(observer2);
            generator.Execute();
            disposable2.Dispose();
            Console.WriteLine("disposable2.Dispose実行");
            generator.Execute();
            
            disposable1.Dispose();
            Console.WriteLine("disposable1.Dispose実行");
            generator.Execute();
        }
    }
}
