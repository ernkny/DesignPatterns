using AdapterDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Concrete
{
    /// <summary>
    /// An adapter class that allows the StripePayment class to be used
    /// with the IPaymentGateway interface. This enables the integration of Stripe's
    /// payment processing capabilities within systems that expect an IPaymentGateway.
    /// </summary>
    public class StripeAdapter:IPaymentGateway
    {
        private  readonly StripePayment _stripe;

        /// <summary>
        /// Initializes a new instance of the StripeAdapter class with a specific StripePayment instance.
        /// This constructor sets up the Stripe payment processing functionality to be used through
        /// the IPaymentGateway interface.
        /// </summary>
        /// <param name="stripe">The StripePayment object that handles the actual payment processing.</param>
        public StripeAdapter(StripePayment stripe)
        {
            _stripe = stripe;
        }

        /// <summary>
        /// Processes a payment through Stripe by calling the SubmitPayment method
        /// on the StripePayment instance. This method adapts the StripePayment's interface
        /// to conform to the IPaymentGateway's requirements.
        /// </summary>
        /// <param name="amount">The amount of money to process as payment.</param>
        public async Task<bool> ProcessPayment(decimal amount)
        {
            return await _stripe.SubmitPayment(amount);
        }
    }
}
