using System;
namespace Chain_of_Responsibility
{
    public class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(Trouble trouble)
        {
            if(trouble.GetNumber() % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
