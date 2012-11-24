using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics.Exceptions
{
    public class InvalidDNAException : ApplicationException
    {
        public InvalidDNAException() { }

        public InvalidDNAException(string message) : base(message) { }

        public InvalidDNAException(string message, Exception innerException) : base(message, innerException) { }
    }
}
