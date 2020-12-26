using System;
using System.Runtime.Serialization;

namespace Jabuticaba
{
    [Serializable]
    internal class CnpjInvalidoException : Exception
    {
        public CnpjInvalidoException()
        {
        }

        public CnpjInvalidoException(string message) : base(message)
        {
        }

        public CnpjInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CnpjInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}