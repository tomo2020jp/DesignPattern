using System;
namespace Adapter2
{
    public class PrintBanner : Print
    {
        private readonly Banner banner;
        public PrintBanner(string str)
        {
            this.banner = new Banner(str);
        }

        public override void PrintString()
        {
            banner.ShowWithAster();
        }

        public override void PrintWeak()
        {
            banner.ShowWithParen();
        }
    }
}
