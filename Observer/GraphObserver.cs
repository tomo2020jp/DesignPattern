using System;
using System.Threading;

namespace Observer
{
    public class GraphObserver : IMyObserver
    {
        public void Update(NumberGenerator generator)
        {
            Console.Write("GraphObserver:");
            int count = generator.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            try
            {
                Thread.Sleep(100);
            }
            catch (ThreadInterruptedException ex)
            {

            }
        }
    }
}
