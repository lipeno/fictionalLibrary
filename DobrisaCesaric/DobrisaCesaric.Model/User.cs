using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public abstract class User
    {
        private string _firstName;
        private string _lastName;
        private string _telephoneNumber;
        private string _email;

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string TelephoneNumber
        {
            get { return _telephoneNumber; }
            set { _telephoneNumber = value; }
        }
    }
}
