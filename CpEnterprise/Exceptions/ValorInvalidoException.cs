using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEnterprise.Exceptions
{
    [Serializable]
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException() { }
        public ValorInvalidoException(string message) : base(message) { }
        public ValorInvalidoException(string message, Exception inner) : base(message, inner) { }
        protected ValorInvalidoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
