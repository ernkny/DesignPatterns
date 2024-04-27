using Chain_of_Responsibility.Abstract;
using Chain_of_Responsibility.Concrete.Entity;
using Chain_of_Responsibility.InMemoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern
{
    /// <summary>
    /// Handles payment verification in a chain of responsibility pattern implementation.
    /// This class verifies the payment status of an order through an external API before potentially passing the order item to the next handler in the chain.
    /// </summary>
    public class PaymentControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;

        /// <summary>
        /// Sets the next handler in the chain of responsibility.
        /// </summary>
        /// <param name="abstractHandlerChain">The next handler to be set.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Processes an order item by checking the payment status through an API call.
        /// If the payment is verified, it may pass the order item to the next handler in the chain if one exists.
        /// </summary>
        /// <param name="orderItem">The order item to handle.</param>
        /// <returns>A task result containing a boolean value that indicates whether the payment for the order item was successfully verified.</returns>
        public override async Task<bool> Handle(OrderItem orderItem)
        {
            // Verify payment through an external API
            return await Task.Run(() => InMemoryDataForOrder.PaymentCheckedFromAPI());
        }

    }

}
