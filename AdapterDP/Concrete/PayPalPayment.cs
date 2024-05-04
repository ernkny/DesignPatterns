using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    /// <summary>
    /// Represents a class for handling payments through PayPal.
    /// This class provides functionality to make payments using PayPal's services.
    /// </summary>
    public class PayPalPayment
    {
        /// <summary>
        /// Initiates a payment of the specified amount via PayPal.
        /// This method logs the payment amount to the console and simulates a payment process.
        /// </summary>
        /// <param name="amount">The monetary amount to be processed as payment.</param>
        public async Task<bool> MakePayment(decimal amount)
        {
            Console.WriteLine($"PayPal: Processing ${amount}");
            // Simulate payment processing delay
            await Task.Delay(1000);
            return true;
        }
    }
}
