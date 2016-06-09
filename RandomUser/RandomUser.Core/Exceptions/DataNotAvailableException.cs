using System;

namespace RandomUser.Core.Exceptions
{
    public class DataNotAvailableException : Exception
    {
        public DataNotAvailableException()
        {
        }

        public DataNotAvailableException(string message) : base(message)
        {
        }

        public DataNotAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}