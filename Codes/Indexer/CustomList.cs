using System.Collections;

namespace Indexer
{
    internal class CustomList 
    {
        private Book[] _books;
        public CustomList(int size)
        {
            _books = new Book[size];
        }

        public Book this[int index]
        {
            get 
            {
                if (index<0 || index>_books.Length-1)
                  throw new IndexOutOfRangeException("Index out of range");

                  return _books[index]; 
            }
            set 
            {
                if (index < 0 || index > _books.Length - 1)
                    throw new IndexOutOfRangeException("Index out of range");
                _books[index] = value; 
            }
        }

        
    }
}
