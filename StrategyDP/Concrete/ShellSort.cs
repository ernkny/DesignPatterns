﻿using StrategyDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.Concrete
{
    public class ShellSort : StrategyOfSorting
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell Sorting");
        }
    }
}
