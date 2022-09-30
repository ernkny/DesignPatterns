using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Concrete
{
    public class BakiyeControl
    {
        public bool BakiyeYeterliMi(Customer c, int amount)
        {
            Console.WriteLine("Bakiye Yeterli: " + amount);
            return true;
        }
    }
}
