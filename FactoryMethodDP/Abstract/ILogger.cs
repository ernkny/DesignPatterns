using System.Threading.Tasks;

namespace FactoryMethodDP.Abstract
{
    /// <summary>
    /// Defines a common interface for all logger types.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message asynchronously.
        /// </summary>
        /// <param name="message">Message to be logged.</param>
        Task log(string message);
    }
}
