using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.Utility
{
    public interface IAddAuthor
    {
        bool ShowForm();

        string getAuthorName();

        string getAuthorDescription();

        DateTime getAuthorDob();
    }
}
