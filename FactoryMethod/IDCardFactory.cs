using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class IDCardFactory : Factory
    {
        public IList<string> Owners { get; private set; } = new List<string>();
        public override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        public override void RegisterProduct(Product product)
        {
            Owners.Add(((IDCard)product).Owner);
        }
    }
}
