using FactoryMethodDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    internal class DatabaseLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine(message + " DataBase Log Works " + DateTime.Now.ToString());
        }
    }
}
