using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DobrisaCesaric.DomainModel
{
    public class Book
    {
        private Guid _id;
        private string _isbn;
        private List<Author> _authors = new List<Author>();
        private string _name;

        // obavezni podatci
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        [Required]
        public List<Author> Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }

        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //neobavezni
        public string Nakladnik{ get; set; }
        public DateTime yearReleased{ get; set; }
        public int releaseNumber{ get; set; }
        public string bookDescription{ get; set; }
        public string language{ get; set; }
        public Enums.VrstaKnjige BookType { get; set; }
        private Enums.GradjaKnjige bookStructure;
        
        public Enums.GradjaKnjige BookStructure{ 
            get {return bookStructure;}
            set { bookStructure = value; } 
        }
        public int pageNumber{ get; set; }
        //trenutne dostupnosti

        public Book(Guid id, string isbn, List<Author> authors, string name)
        {
            _id = Id;

            _isbn = isbn;
            _authors = authors;
            _name = name;
        }
    }
}
