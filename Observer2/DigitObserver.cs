using System;
using System.Threading;

namespace Observer2
{
    public class DigitObserver : IObserver<NumberGenerator>
    {
        public DigitObserver()
        {
        }

        public void OnCompleted()
        {
            Console.WriteLine("通知の受信完了(DigitObserver)。");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"エラー発生(DigitObserver){error.Message}");
        }

        public void OnNext(NumberGenerator value)
        {
            Console.WriteLine($"通知受信(DigitObserver):{value.GetNumber()}");
            Thread.Sleep(100);
        }
    }
}
