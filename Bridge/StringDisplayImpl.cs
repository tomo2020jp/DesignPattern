using System;
using System.Text;

namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;
        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = Encoding.GetEncoding("Shift_JIS").GetByteCount(str);
        }

        public override void RawClose()
        {
            PrintLine();
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{str}|");
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
