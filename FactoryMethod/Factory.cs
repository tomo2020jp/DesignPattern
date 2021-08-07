using System;
namespace FactoryMethod
{
    public abstract class Factory
    {
        public Product Create(string owner)
        {
            var p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }

        public abstract Product CreateProduct(string owner);
        public abstract void RegisterProduct(Product product);
    }
}
