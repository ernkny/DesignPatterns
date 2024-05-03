using AdapterDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    public class StripeAdapter:IPaymentGateway
    {
        private StripePayment _stripe;

        public StripeAdapter(StripePayment stripe)
        {
            _stripe = stripe;
        }

        public async Task<bool> ProcessPayment(decimal amount)
        {
            return await _stripe.SubmitPayment(amount);
        }
    }
}
