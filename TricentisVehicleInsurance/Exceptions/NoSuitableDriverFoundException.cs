using System;
using System.Collections.Generic;
using System.Text;

namespace TricentisVehicleInsurance.Exceptions
{
    /// <summary>
    /// Exception thrown when no suitable Selenium webdriver is found.
    /// </summary>
    class NoSuitableDriverFoundException : Exception
    {
        /// <summary>
        /// Returns a new NoSuitableDriverFoundException.
        /// </summary>
        public NoSuitableDriverFoundException() : base() { }
        /// <summary>
        /// Returns a new NoSuitableDriverFoundException with message <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public NoSuitableDriverFoundException(string message) : base(message) { }
    }
}
