using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    public class StripePayment
    {
        public async Task<bool> SubmitPayment(decimal amount)
        {
            Console.WriteLine($"Stripe: Processing ${amount}");
            return true;
        }
    }
}
