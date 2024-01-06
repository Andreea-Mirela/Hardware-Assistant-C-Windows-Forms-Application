using System;

namespace HardwareAssistant.Exceptions
{
    public class DataAccessException : Exception
    {
        public DataAccessException(string message) : base(message) { }
    }
}
