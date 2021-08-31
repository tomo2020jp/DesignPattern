using System;
using System.Runtime.CompilerServices;

namespace Proxy
{
    public class PrinterProxy : IPrintable
    {
        private string name;
        private Printer real;
        public PrinterProxy()
        {
        }

        public PrinterProxy(string name)
        {
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Realize();
            real.Print(str);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetPrinterName(string name)
        {
            if(real != null)
            {
                real.SetPrinterName(name);
            }
            this.name = name;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void Realize()
        {
            if(real == null)
            {
                real = new Printer(name);
            }
        }
    }
}
