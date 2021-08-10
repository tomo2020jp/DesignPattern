using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            var obj1 = Singleton.GetSingleton();
            var obj2 = Singleton.GetSingleton();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }
            Console.WriteLine("End.");
        }
    }
}
