using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class Author
    {
        public string Name;
        public DateTime Dob;
        public string Description;
        public List<Book> Books = new List<Book>();

        public Author(string name, string description, DateTime dob)
        {
            Name = name;
            Dob = dob;
            Description = description;
        }

        public Author(string name)
        {
            Name = name;
        }

        public void DefineDescription(string inDescription)
        {
            Description = inDescription;
        }
    }
}
