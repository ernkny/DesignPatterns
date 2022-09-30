using StrategyDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.Concrete
{
    public class SortedList
    {
        private List<string> list = new List<string>();
        private StrategyOfSorting _sortstrategy;

        public void SetSortStrategy(StrategyOfSorting sortstrategy)
        {
            _sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            _sortstrategy.Sort(list);
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}

