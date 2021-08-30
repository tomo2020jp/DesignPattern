using System;
using System.IO;
using System.Text;

namespace Flyweight
{
    public class BigChar
    {
        private char charname;
        private string fontdata;
        public BigChar(char charname)
        {
            this.charname = charname;
            using (var reader = new StreamReader($"big{charname}.txt"))
            {
                string line;
                StringBuilder buf = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    buf.Append(line);
                    buf.Append("\n");
                }
                fontdata = buf.ToString();
            }
        }

        public void Print()
        {
            Console.Write(fontdata);
        }
    }
}
