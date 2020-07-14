using System;

namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {
        }

        public InvalidArgumentException(string message)
            : base(message)
        {
        }

        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }
}
