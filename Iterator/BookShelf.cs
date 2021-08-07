using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        IList<Book> books = new List<Book>();
        int last = 0;
        public BookShelf()
        {
        }

        public Book GetBookAt(int index)
        {
            return books[index];
        }

        public void AppendBook(Book book)
        {
            books.Add(book);
            last++;
        }

        public int GetLength()
        {
            return last;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
