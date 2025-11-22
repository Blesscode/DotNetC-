using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_userDefineException
{
    internal class AgeTooSmallException : Exception
    {
        public AgeTooSmallException() : base("Age should not be less than 18"){ } //for non-parameter error throws
        public AgeTooSmallException(String message):base(message) { } //for parameter error throws
    }
}
