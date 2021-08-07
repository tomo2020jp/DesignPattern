using System;

namespace Adapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintString();
        }
    }
}
