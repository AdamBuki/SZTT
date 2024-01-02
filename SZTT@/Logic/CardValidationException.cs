using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTT_.Logic
{
    public class CardValidationException : Exception
    {
        public CardValidationException(string message) : base(message)
        {
        }
    }
}
