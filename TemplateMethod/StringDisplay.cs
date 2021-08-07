using System;
using System.Text;

namespace TemplateMethod
{
    public class StringDisplay:AbstractDisplay
    {
        private readonly string str;
        private readonly int width;
        public StringDisplay(string str)
        {
            this.str = str;
            this.width = Encoding.GetEncoding("Shift_JIS").GetByteCount(str);
        }

        public override void Close()
        {
            PrintLine();
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{str}|");
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
