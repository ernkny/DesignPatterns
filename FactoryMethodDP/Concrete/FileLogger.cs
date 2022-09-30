﻿using FactoryMethodDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP.Concrete
{
    public class FileLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine(message+ " File Log Works " + DateTime.Now.ToString());
        }
    }
}
