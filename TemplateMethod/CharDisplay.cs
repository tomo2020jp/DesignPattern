using System;
namespace TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private readonly char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(ch);
        }
    }
}
