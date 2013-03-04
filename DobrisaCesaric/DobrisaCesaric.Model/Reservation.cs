using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class Reservation
    {
        public Book Book { get; set; }
        public BookLender BookLender { get; set; }
        public DateTime TargetReservationDate { get; set; }

        public Reservation(Book inBook, BookLender inLender, DateTime inTime)
        {
            Book = inBook;
            BookLender = inLender;
            TargetReservationDate = inTime;
        }
    }
}
