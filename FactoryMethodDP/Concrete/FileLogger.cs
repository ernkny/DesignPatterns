using FactoryMethodDP.Abstract;
using System;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    /// <summary>
    /// Implements logging to a file.
    /// </summary>
    public class FileLogger : ILogger
    {
        /// <summary>
        /// Logs a message to a file along with the current date and time.
        /// This is a stub for demonstration, actual file logging would involve file system operations.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public async Task log(string message)
        {
            Console.WriteLine(message + " File Log Works " + DateTime.Now.ToString());  // Placeholder for actual file logging
        }
    }

}
