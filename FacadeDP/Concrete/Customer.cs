using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Concrete
{
    public class Customer
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
