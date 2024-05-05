using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    /// <summary>
    /// Represents a class for handling payments through Stripe.
    /// This class encapsulates the functionality necessary to submit payments using Stripe's payment processing services.
    /// </summary>
    public class StripePayment
    {
        /// <summary>
        /// Submits a payment of the specified amount via Stripe.
        /// This method logs the payment amount to the console and simulates the payment processing to mimic a real transaction.
        /// </summary>
        /// <param name="amount">The monetary amount to be processed as payment.</param>
        public async Task<bool> SubmitPayment(decimal amount)
        {
            Console.WriteLine($"Stripe: Processing ${amount}");
            // Simulate payment processing delay
            await Task.Delay(1000);
            return true;
        }
    }
}
