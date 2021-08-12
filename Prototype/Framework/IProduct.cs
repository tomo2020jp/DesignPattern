using System;
namespace Prototype.Framework
{
    public interface IProduct : ICloneable
    {
        void Use(string s);
        IProduct CreateClone();
    }
}
