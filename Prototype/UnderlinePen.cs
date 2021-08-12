using System;
using System.Text;
using Prototype.Framework;

namespace Prototype
{
    public class UnderlinePen:IProduct
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public void Use(string s)
        {
            int length = Encoding.GetEncoding("Shift_JIS").GetByteCount(s);
            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");
            for(int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine(" ");
        }

        public IProduct CreateClone()
        {
            return (IProduct)Clone();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
