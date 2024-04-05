using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CustomInputException : Exception
    {
        public CustomInputException() : base() { }

        public CustomInputException(string message) : base(message) { }

        public CustomInputException(string message, Exception innerException) : base(message, innerException) { }
    }
}
