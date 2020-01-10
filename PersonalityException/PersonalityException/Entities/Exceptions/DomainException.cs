using System;
using PersonalityException.Entities.Exceptions;


namespace PersonalityException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
