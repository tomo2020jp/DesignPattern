using System;
namespace Composite
{
    public abstract class Entry
    {
        public abstract string GetName();
        public abstract int GetSize();

        public abstract Entry Add(Entry entry);

        public void PrintList()
        {
            PrintList("");
        }

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return $"{GetName()}({GetSize()})";
        }
    }
}
