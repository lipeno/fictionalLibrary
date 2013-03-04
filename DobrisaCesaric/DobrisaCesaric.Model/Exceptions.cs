using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// exceptions used in model
namespace DobrisaCesaric.DomainModel
{
    [Serializable]
    public class DobrisaCesaricBaseException : Exception
    {
    }

    [Serializable]
    public class AlreadyExists : DobrisaCesaricBaseException
    {

    }

    [Serializable]
    public class DoesntExist : DobrisaCesaricBaseException
    {

    }
}
