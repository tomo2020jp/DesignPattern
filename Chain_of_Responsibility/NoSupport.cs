using System;
namespace Chain_of_Responsibility
{
    public class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}
