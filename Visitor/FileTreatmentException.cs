using System;
namespace Visitor
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException() : base()
        {
        }

        public FileTreatmentException(string message) : base(message)
        {
        }

        public FileTreatmentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
