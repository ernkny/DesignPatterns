using AdapterDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    /// <summary>
    /// An adapter class that enables the use of PayPal payment services
    /// through the common IPaymentGateway interface. This allows the PayPalPayment
    /// class to be used in the application where IPaymentGateway is expected.
    /// </summary>
    public class PayPalAdapter: IPaymentGateway
    {
        private readonly PayPalPayment _payPal;

        /// <summary>
        /// Initializes a new instance of the PayPalAdapter class.
        /// </summary>
        /// <param name="payPal">The PayPal payment instance to be used by this adapter.</param>
        public PayPalAdapter(PayPalPayment payPal)
        {
            _payPal = payPal;
        }

        /// <summary>
        /// Processes the payment using the underlying PayPalPayment instance.
        /// </summary>
        public async Task<bool> ProcessPayment(decimal amount)
        {
            return await _payPal.MakePayment(amount);
        }
    }
}
