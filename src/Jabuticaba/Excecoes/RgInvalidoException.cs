using System;
using System.Runtime.Serialization;

namespace Jabuticaba.OrgaoEmissor
{
    [Serializable]
    internal class RgInvalidoException : Exception
    {
        public RgInvalidoException()
        {
        }

        public RgInvalidoException(string message) : base(message)
        {
        }

        public RgInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RgInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}