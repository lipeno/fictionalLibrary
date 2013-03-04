using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class NormalLender : BookLender
    {
       public DateTime validUntil;

        public NormalLender( string inFirstName, string inLastName,string inTelephoneNumber,string inEmail) :base(inFirstName, inLastName,inTelephoneNumber,inEmail)
        {
            Email = inEmail;
            LastName = inLastName;
            FirstName = inFirstName;
            TelephoneNumber = inTelephoneNumber;
        }


    }
}
