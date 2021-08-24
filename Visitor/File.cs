using System;
using System.Collections.Generic;

namespace Visitor
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

        public override IEnumerator<Entry> Iterator()
        {
            throw new FileTreatmentException();
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
