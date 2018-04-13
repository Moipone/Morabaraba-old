using System;
using System.Collections.Generic;
using System.Text;

namespace Morabaraba_9001
{
    public class IllegalMoves : ApplicationException
    {
        public IllegalMoves(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
