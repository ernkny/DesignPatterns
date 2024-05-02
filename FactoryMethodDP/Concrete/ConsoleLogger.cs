using FactoryMethodDP.Abstract;
using System;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    /// <summary>
    /// Implements logging to the console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the console along with the current date and time.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public async Task log(string message)
        {
            Console.WriteLine(message + " Console Log Works " + DateTime.Now.ToString());
        }
    }
}
