using System;
using System.Runtime.Serialization;

namespace Template.Business.Exceptions
{
    public class TemplateException : Exception
    {
        public TemplateException()
        {
        }

        public TemplateException(string message) : base(message)
        {
        }

        public TemplateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TemplateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
