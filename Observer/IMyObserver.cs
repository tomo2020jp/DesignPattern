using System;
namespace Observer
{
    public interface IMyObserver
    {
        void Update(NumberGenerator generator);
    }
}
