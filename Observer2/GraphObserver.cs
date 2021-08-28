using System;
using System.Threading;

namespace Observer2
{
    public class GraphObserver : IObserver<NumberGenerator>
    {
        public void OnCompleted()
        {
            Console.WriteLine("通知の受信完了(GraphObserver)。");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"エラー発生(GraphObserver){error.Message}");
        }

        public void OnNext(NumberGenerator value)
        {
            Console.Write($"通知受信(GraphObserver):{value}");
            int count = value.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Thread.Sleep(100);
        }
    }
}
