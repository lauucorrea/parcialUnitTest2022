using System;

namespace Entidades
{
    public class ExplotaException : Exception
    {
        public ExplotaException()
        {
        }

        public ExplotaException(string message) : base(message)
        {
        }

        public ExplotaException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
