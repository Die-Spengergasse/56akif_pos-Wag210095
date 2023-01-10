// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

namespace Basis.CSharp
{
    [Serializable]
    internal class NoXyException : Exception
    {
        public NoXyException()
        {
        }

        public NoXyException(string? message) : base(message)
        {
        }

        public NoXyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoXyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}