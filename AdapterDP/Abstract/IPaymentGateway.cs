using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Abstract
{
    /// <summary>
    /// Provides an interface for payment gateway implementations.
    /// This interface defines a standard contract for processing payments
    /// through different payment service providers.
    /// </summary>
    public interface IPaymentGateway
    {
        /// <summary>
        /// Processes a payment with the specified amount.
        /// </summary>
        /// <param name="amount">The amount of money to process as payment.</param>
        /// <returns>
        Task<bool> ProcessPayment(decimal amount);
    }
}

