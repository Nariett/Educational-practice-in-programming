using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part60
{
    internal class DigitException:Exception
    {
        public DigitException() { }
        public DigitException(string message) : base(message) { }
        public DigitException(string message, Exception innerException) : base(message, innerException) { }
    }
}
