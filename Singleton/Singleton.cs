using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetSingleton()
        {
            return singleton;
        }
    }
}
