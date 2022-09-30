using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Concrete
{
    public class PuanControl
    {
        public bool PuanYeterliMi(Customer c)
        {
            Console.WriteLine("Puan kontrolü yapıldı"+c.Name);
            return true;
        }
    }
}
