using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Dabby-Long-Legs"));
            var it = bookShelf.Iterator();
            while(it.HasNext())
            {
                var book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }

        }
    }
}
