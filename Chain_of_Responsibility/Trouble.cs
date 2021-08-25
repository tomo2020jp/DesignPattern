using System;
namespace Chain_of_Responsibility
{
    public class Trouble
    {
        private int number;
        public Trouble(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }

        public override string ToString()
        {
            return $"[Trouble {number}]";
        }
    }
}
