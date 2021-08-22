using System;
namespace Composite
{
    public class File : Entry
    {
        private string name;
        private int size;
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public override Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
        }
    }
}
