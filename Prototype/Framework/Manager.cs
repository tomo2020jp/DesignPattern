using System;
using System.Collections.Generic;

namespace Prototype.Framework
{
    public class Manager
    {
        private IDictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        public IProduct Create(string protoname)
        {
            IProduct p = showcase[protoname];
            return p.CreateClone();
        }
    }
}
