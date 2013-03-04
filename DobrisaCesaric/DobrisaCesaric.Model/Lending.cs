using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class Lending
    {
        // za posudbu knjige je uvijek potrebna interakcija knjižničara
        public const int holdingTimeInDays = 30;
        public const decimal koef = 2;

        public Librarian Librarian { get; set; }
        public bool Returned{ get; set; }

        public Book Book { get; set; }

        public BookLender BookLender { get; set; }
        public DateTime LendingDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Lending(Book inBook, BookLender inLender, Librarian inLibrarian, DateTime inTime)
        {
            Book = inBook;
            BookLender = inLender;
            LendingDate = inTime;
            Librarian = inLibrarian;
            Returned = false;
        }

        public void ReturnBook(Book inBook, BookLender inLender, Librarian inLibrarian, DateTime inTime)
        {
            if (inTime > LendingDate.AddDays(holdingTimeInDays))
            {
            ReturnDate = inTime;
            Returned = true;
            }
            else
            {
                PayForLateReturn(inLender, inTime - LendingDate.AddDays(holdingTimeInDays));
                ReturnDate = inTime;
                Returned = true;
            }
        }
        // return amount to pay for being late
        public decimal PayForLateReturn(BookLender inLender, TimeSpan inTimeSpan)
        {
            return (new Decimal(inTimeSpan.TotalDays) * koef);
        }
    }
}
