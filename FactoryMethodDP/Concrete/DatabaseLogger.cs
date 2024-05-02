using FactoryMethodDP.Abstract;
using System;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    /// <summary>
    /// Implements logging to a database.
    /// </summary>
    public class DatabaseLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the database log along with the current date and time.
        /// This is a stub for demonstration, as actual database logging would require database operations.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public async Task log(string message)
        {
            Console.WriteLine(message + " DataBase Log Works " + DateTime.Now.ToString());  // Placeholder for actual DB logging
        }
    }
}

