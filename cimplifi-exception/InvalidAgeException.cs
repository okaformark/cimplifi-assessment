using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_exception
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string? message) : base(message)
        {
        }

        public InvalidAgeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
