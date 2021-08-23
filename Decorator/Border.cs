using System;
namespace Decorator
{
    public abstract class Border : Display
    {
        protected Display display;
        protected Border(Display display)
        {
            this.display = display;
        }
    }
}
