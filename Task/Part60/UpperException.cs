using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part60
{
    internal class UpperException:Exception
    {
        public UpperException()
        {
        }
        public UpperException(string message) : base(message){}
        public UpperException(string message, Exception innerException) : base(message, innerException){}
    }
}
