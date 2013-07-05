using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocExample
{
    public class UnknownTypeException : Exception
    {
        public UnknownTypeException(string message)
            : base(message)
        {
            //do something here
        }
    }

    public class TypeExistsException : Exception
    {
        public TypeExistsException(string message)
            : base(message)
        {
            //do something here
        }
    }
}