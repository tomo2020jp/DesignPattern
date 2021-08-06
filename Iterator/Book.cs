using System;
namespace Iterator
{
    public class Book
    {
        readonly string name;
        public Book(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
