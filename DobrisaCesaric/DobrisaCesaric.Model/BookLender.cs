using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class BookLender : User, IMembership
    {
        public DateTime MemberSince { get; set; }
        public string Comment { get; set; }

        public BookLender(string inFirstName, string inLastName, string inTelephoneNumber, string inEmail)
        {
            Email = inEmail;
            LastName = inLastName;
            FirstName = inFirstName;
            TelephoneNumber = inTelephoneNumber;
        }

        public double MembershipDuration()
        {
            return (DateTime.Now - MemberSince).Days;
        }
    }
}
