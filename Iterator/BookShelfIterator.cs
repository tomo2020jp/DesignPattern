using System;
namespace Iterator
{
    public class BookShelfIterator:IIterator
    {
        readonly BookShelf bookShelf;
        private int index = 0;
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
        }

        public bool HasNext()
        {
            if (index < bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            var book = bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
