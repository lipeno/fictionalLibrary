using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class Librarian : User
    {
        public string Department { get; set; }
        public DateTime StartOfContract { get; set; }

        public Librarian(string inFirstName, string inLastName, string inTelephoneNumber, string inEmail, string inDepartment, DateTime inStartOfContract)
        {
            Email = inEmail;
            LastName = inLastName;
            FirstName = inFirstName;
            TelephoneNumber = inTelephoneNumber;
            Department = inDepartment;
            StartOfContract = inStartOfContract;
        }
    }
}
