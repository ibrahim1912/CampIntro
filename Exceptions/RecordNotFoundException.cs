using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFoundException:Exception  //exception görevi görcek inherit ettik
    {
        public RecordNotFoundException(string message) : base(message)
        {

        }

    }
}
