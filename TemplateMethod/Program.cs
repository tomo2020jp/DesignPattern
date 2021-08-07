using System;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");
            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}
