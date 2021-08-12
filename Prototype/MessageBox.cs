using System;
using System.Text;
using Prototype.Framework;

namespace Prototype
{
    public class MessageBox : IProduct
    {
        private char decochar;
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IProduct CreateClone()
        {
            return (IProduct)Clone();
        }

        public void Use(string s)
        {
            int length = Encoding.GetEncoding("Shift_JIS").GetByteCount(s);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }

    }
}
