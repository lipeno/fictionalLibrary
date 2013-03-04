using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class StudentLender : BookLender
    {
        public string Xica { get; set; }
        public bool PotvrdjenZaAkademGodinu { get; set; }

        public StudentLender(string inFirstName, string inLastName, string inTelephoneNumber, string inEmail, string inXica)
            : base(inFirstName, inLastName, inTelephoneNumber, inEmail)
        {
            Email = inEmail;
            LastName = inLastName;
            FirstName = inFirstName;
            TelephoneNumber = inTelephoneNumber;
            Xica = inXica;
            PotvrdjenZaAkademGodinu = true;
        }

        public void PotvrdiZaAkademGodinu()
        {
            PotvrdjenZaAkademGodinu = true;
        }
    }
}
