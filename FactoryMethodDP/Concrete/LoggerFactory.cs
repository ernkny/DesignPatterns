using FactoryMethodDP.Abstract;

namespace FactoryMethodDP.Concrete
{
    /// <summary>
    /// Defines the types of loggers available.
    /// </summary>
    public enum LoggerType
    {
        Console,
        Database,
        File
    }

    /// <summary>
    /// Factory class for creating logger instances based on the specified logger type.
    /// </summary>
    public class LoggerFactory
    {
        /// <summary>
        /// Creates and returns an instance of ILogger based on the specified LoggerType.
        /// </summary>
        /// <param name="logType">The type of logger to create.</param>
        /// <returns>An ILogger instance of the specified type.</returns>
        public ILogger CreateLogger(LoggerType logType)
        {
            ILogger logger;
            switch (logType)
            {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;
                case LoggerType.Database:
                    logger = new DatabaseLogger();
                    break;
                case LoggerType.File:
                    logger = new FileLogger();
                    break;
                default:
                    logger = new ConsoleLogger(); // Default to console logger if an unknown type is specified
                    break;
            }
            return logger;
        }
    }
}
