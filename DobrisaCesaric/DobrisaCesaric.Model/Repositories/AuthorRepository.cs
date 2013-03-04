using System.Collections.Generic;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.DomainModel.Repositories
{
    public class AuthorRepository : Subject
    {
        private static AuthorRepository _instance;
        private readonly List<Author> _listauthors = new List<Author>();

        private AuthorRepository()
        {
            
        }

        public static AuthorRepository GetInstance()
        {
            if (_instance == null)
                _instance = new AuthorRepository();

            return _instance;
        }

        public int Count()
        {
            return _listauthors.Count;
        }

        public void AddAuthor(Author newauthor)
        {
            foreach (Author author in _listauthors)
                if (author.Name == newauthor.Name)
                    throw new AlreadyExists();

            _listauthors.Add(newauthor);

            notifyObservers();
        }

        public Author GetAuthorByName(string authorName)
        {
            foreach (Author author in _listauthors)
                if (author.Name == authorName)
                    return author;
            return null;
        }

        public Author GetAuthorByIndex(int index)
        {
            if (0 <= index && index < Count())
                return _listauthors[index];
            else
                throw new DoesntExist();
        }

        public bool AuthorExists(string authorName)
        {
            return GetAuthorByName(authorName) != null;
        }
    }
}