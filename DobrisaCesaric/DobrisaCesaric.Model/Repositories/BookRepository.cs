using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.DomainModel.Repositories
{
    public class BookRepository : Subject
    {
        private static BookRepository _instance = null;
        private List<Book> _listBooks = new List<Book>();

        private BookRepository()
        {
        }

        public static BookRepository GetInstance()
        {
            if (_instance == null)
                _instance = new BookRepository();

            return _instance;
        }

        public int Count()
        {
            return _listBooks.Count;
        }

        public void AddBook(Book newBook)
        {
                if (BookExists(newBook.Name))
                    throw new AlreadyExists();

            _listBooks.Add(newBook);

            notifyObservers();
        }

        public Book GetBookByName(string bookName)
        {
            foreach (Book book in _listBooks)
                if (book.Name == bookName)
                    return book;
            return null;
        }
        public Book GetBookByIndex(int index)
        {
            if (0 <= index && index < Count())
                return _listBooks[index];
            else
                throw new DoesntExist();
        }

        public bool BookExists(string bookName)
        {
            return GetBookByName(bookName) != null;
        }
    }
}
