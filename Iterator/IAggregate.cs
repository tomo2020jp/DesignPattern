using System;
namespace Iterator
{
    public interface IAggregate
    {
        IIterator Iterator();
    }
}
