using System;
namespace Adapter
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str) : base(str)
        {
        }

        public void PrintString()
        {
            ShowWithAster();
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }
    }
}
