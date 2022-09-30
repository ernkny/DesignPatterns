using FactoryMethodDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    public enum LoggerType
    {
        Console,
        Database,
        File
    }
    public class LoggerFactory
    {
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
                    logger = new ConsoleLogger();
                    break;
            }
            return logger;
        }
    }
}
