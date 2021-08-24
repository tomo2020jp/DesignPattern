using System;
using System.Collections.Generic;

namespace Visitor
{
    public class Directory : Entry
    {
        private string name;
        private IList<Entry> dir = new List<Entry>();
        public Directory(string name)
        {
            this.name = name;
        }

        public override Entry Add(Entry entry)
        {
            dir.Add(entry);
            return this;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int size = 0;
            var it = dir.GetEnumerator();
            while (it.MoveNext())
            {
                size += it.Current.GetSize();
            }
            return size;
        }

        public override IEnumerator<Entry> Iterator()
        {
            return dir.GetEnumerator();
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

        public override string ToString()
        {
            return $"{GetName()}({GetSize()})";
        }
    }
}
