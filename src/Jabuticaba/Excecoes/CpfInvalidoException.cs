using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

[assembly: InternalsVisibleTo("JabuticabaTests")]
namespace Jabuticaba.Excecoes
{
    [Serializable]
    internal class CpfInvalidoException : Exception
    {
        public CpfInvalidoException()
        {
        }

        public CpfInvalidoException(string message) : base(message)
        {
        }

        public CpfInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CpfInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}