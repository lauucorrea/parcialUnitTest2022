using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class RuedaEnLLantaException : Exception
    {
        public RuedaEnLLantaException()
        {
        }

        public RuedaEnLLantaException(string message) : base(message)
        {
        }

        public RuedaEnLLantaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RuedaEnLLantaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}