using System.Collections.Generic;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.DomainModel.Repositories
{
    public class UserRepository : Subject
    {
        private static UserRepository _instance;
        private readonly List<User> _listusers = new List<User>();

        private UserRepository()
        {
        }

        public static UserRepository GetInstance()
        {
            if (_instance == null)
                _instance = new UserRepository();

            return _instance;
        }

        public int Count()
        {
            return _listusers.Count;
        }

        public void Adduser(User newuser)
        {
            foreach (User user in _listusers)
                if (user.GetFullName() == newuser.GetFullName())
                    throw new AlreadyExists();

            _listusers.Add(newuser);

            //notifyObservers();
        }

        public User GetuserByFirstName(string userName)
        {
            foreach (User user in _listusers)
                if (user.FirstName == userName)
                    return user;
            return null;
        }

        public User GetuserByFullName(string userName)
        {
            foreach (User user in _listusers)
                if (user.GetFullName() == userName)
                    return user;
            return null;
        }

        public Librarian GetLibrarianByFullName(string userName)
        {
            foreach (User user in _listusers)
                if (user.GetFullName() == userName)
                    return (Librarian) user;
            return null;
        }

        public BookLender GetLenderByFullName(string userName)
        {
            foreach (User user in _listusers)
                if (user.GetFullName() == userName)
                    return (BookLender) user;
            return null;
        }


        public User GetuserByIndex(int index)
        {
            if (0 <= index && index < Count())
                return _listusers[index];
            else
                throw new DoesntExist();
        }

        public BookLender GetLenderByIndex(int index)
        {
            if (0 <= index && index < Count())
                return (BookLender) _listusers[index];
            else
                throw new DoesntExist();
        }

        public Librarian GetLibrarianByIndex(int index)
        {
            if (0 <= index && index < Count())
                return (Librarian)_listusers[index];
            else return null;
            //else throw new DoesntExist();
        }

        public bool userExists(string userName)
        {
            return GetuserByFullName(userName) != null;
        }
    }
}