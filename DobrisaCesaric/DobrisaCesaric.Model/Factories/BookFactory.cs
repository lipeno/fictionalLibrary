using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DobrisaCesaric.DomainModel.Repositories;

namespace DobrisaCesaric.DomainModel.Factories
{
    public class BookFactory
    {
        public static Book CreateBook(string isbn, string name, string authorName)
        {
            AuthorRepository authorRepo = AuthorRepository.GetInstance();
            Author author = new Author(authorName);

            if (authorRepo.AuthorExists(authorName))
            {
                author = authorRepo.GetAuthorByName(authorName);
            }
            else
            {
                authorRepo.AddAuthor(author);
                author = authorRepo.GetAuthorByName(authorName);
            }
           
            List<Author> authorList = new List<Author>();
            authorList.Add(author);

            Book newBook = new Book(Guid.NewGuid(), isbn, authorList, name);

            return newBook;
        }

        public static Book CreateBookMoreAuthors(string isbn, string name, List<Author> authorList )
        {
            Book newBook = new Book(Guid.NewGuid(), isbn, authorList, name);

            return newBook;
        }
    }
}
