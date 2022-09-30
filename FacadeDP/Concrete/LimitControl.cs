using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Concrete
{
    public class LimitControl
    {
        public bool LimitYeterliMi(Customer c)
        {
            Console.WriteLine("Limit kontrolü yapıldı" + c.Name);
            return true;
        }
    }
}
