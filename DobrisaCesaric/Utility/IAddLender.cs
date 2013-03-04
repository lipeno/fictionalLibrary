using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.Utility
{
    public interface IAddLender
    {
         bool ShowForm();

         string getFirstName();

         string getLastName();

         DateTime getMemberSince();

         string getTelephone();

        string getEmail();
    }
}
