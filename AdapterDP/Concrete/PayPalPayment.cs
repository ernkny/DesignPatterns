using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    public class PayPalPayment
    {
        public async Task<bool> MakePayment(decimal amount)
        {
            Console.WriteLine($"PayPal: Processing ${amount}");
            return true;
        }
    }
}
