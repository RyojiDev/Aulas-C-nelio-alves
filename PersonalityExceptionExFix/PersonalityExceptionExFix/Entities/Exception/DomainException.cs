using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalityExceptionExFix.Entities.Exception
{
    class DomainException : ApplicationException
    {
       

        public DomainException(string message) : base(message)
        {
           
        }
    }
}
