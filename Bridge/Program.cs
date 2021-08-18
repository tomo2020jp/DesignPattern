using System;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));
            d1.DisplayShow();
            d2.DisplayShow();
            d3.DisplayShow();
            d3.MultiDisplay(5);
        }
    }
}
