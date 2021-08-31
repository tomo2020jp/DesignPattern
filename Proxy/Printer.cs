using System;
using System.Threading;

namespace Proxy
{
    public class Printer : IPrintable
    {
        private string name;
        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }

        public Printer(string name)
        {
            this.name = name;
            HeavyJob($"Printerのインスタンス({name})を生成中");
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Console.WriteLine($"=== {name} ===");
            Console.WriteLine(str);
        }

        public void SetPrinterName(string name)
        {
            this.name = name;
        }

        private void HeavyJob(string msg)
        {
            Console.Write(msg);
            for(int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("完了。");
        }
    }
}
