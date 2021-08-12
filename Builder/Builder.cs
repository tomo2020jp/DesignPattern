using System;
using System.Collections.Generic;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void MakeTitle(string title);
        public abstract void MakeString(string str);
        public abstract void MakeItems(IEnumerable<string> items);
        public abstract void Close();
    }
}
