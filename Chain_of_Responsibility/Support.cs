using System;
namespace Chain_of_Responsibility
{
    public abstract class Support
    {
        private string name;
        private Support next;
        public Support(string name)
        {
            this.name = name;
        }

        public Support SetNext(Support next)
        {
            this.next = next;
            return next;
        }

        public void DoSupport(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            }
            else if (next != null)
            {
                next.DoSupport(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }

        public override string ToString()
        {
            return $"[{name}]";
        }

        protected abstract bool Resolve(Trouble trouble);

        protected void Done(Trouble trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this}");
        }

        protected void Fail(Trouble trouble)
        {
            Console.WriteLine($"{trouble} cannot be resolved.");
        }
    }
}
