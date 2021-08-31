using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable p = new PrinterProxy("Alice");
            Console.WriteLine($"名前は現在{p.GetPrinterName()}です。");
            p.SetPrinterName("Bob");
            Console.WriteLine($"名前は現在{p.GetPrinterName()}です。");
            p.Print("Hello, world.");
        }
    }
}
