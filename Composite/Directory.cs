using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Entry
    {
        private string name;
        private IList<Entry> directory = new List<Entry>();
        public Directory(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int size = 0;
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                size += it.Current.GetSize();
            }
            return size;
        }

        public override Entry Add(Entry entry)
        {
            directory.Add(entry);
            return this;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
            var it = directory.GetEnumerator();
            while (it.MoveNext())
            {
                it.Current.PrintList($"{prefix}/{name}");
            }
        }
    }
}
