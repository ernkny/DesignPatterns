using AdapterDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    public class PayPalAdapter: IPaymentGateway
    {
        private PayPalPayment _payPal;

        public PayPalAdapter(PayPalPayment payPal)
        {
            _payPal = payPal;
        }

        public async Task<bool> ProcessPayment(decimal amount)
        {
            return await _payPal.MakePayment(amount);
        }
    }
}
