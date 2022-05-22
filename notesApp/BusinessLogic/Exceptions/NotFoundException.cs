using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
