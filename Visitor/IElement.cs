using System;
namespace Visitor
{
    public interface IElement
    {
        abstract void Accept(Visitor v);
    }
}
