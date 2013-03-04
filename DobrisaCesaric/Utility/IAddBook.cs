using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.Utility
{
    public interface IAddBook
    {
        bool ShowForm();

        string getBookName();

        string getAuthorName();


        string getIsbn();

    }
}
