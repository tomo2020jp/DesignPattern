using System;
using System.Text;
using Prototype.Framework;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // 準備
            Manager manager = new Manager();
            UnderlinePen upen = new UnderlinePen('-');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.Register("string message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // 生成
            IProduct p1 = manager.Create("string message");
            p1.Use("Hello, world.");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world.");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world.");
        }
    }
}
