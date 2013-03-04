using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.Utility
{
    public interface IAddLibrarian
    {
        bool ShowForm();

        string getFirstName();

        string getLastName();

        DateTime getStartOfContract();

        string getTelephone();

        string getDepartment();

        string getEmail();
    }
}
