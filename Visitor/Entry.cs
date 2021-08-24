using System;
using System.Collections.Generic;

namespace Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string GetName();
        public abstract int GetSize();
        public abstract Entry Add(Entry entry);
        public abstract IEnumerator<Entry> Iterator();

        public override string ToString()
        {
            return $"{GetName()}({GetSize()})";
        }

        public abstract void Accept(Visitor v);
    }
}
