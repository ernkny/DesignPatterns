using Chain_of_Responsibility.Abstract;
using Chain_of_Responsibility.Concrete.Entity;
using Chain_of_Responsibility.InMemoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern
{
    /// <summary>
    /// Handles the verification of customer address information as part of a chain of responsibility.
    /// Ensures that a customer's address exists before allowing the handling of an order item to continue in the chain.
    /// </summary>
    public class AddressControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;
        private int customerId;

        /// <summary>
        /// Initializes a new instance of the AddressControl class with a specified customer ID.
        /// </summary>
        public AddressControl(int customerId)
        {
            this.customerId = customerId;
        }

        /// <summary>
        /// Sets the next handler in the chain of responsibility.
        /// </summary>
        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Processes the given order item by first verifying the associated customer's address.
        /// If the customer's address is valid, the processing is passed on to the next handler in the chain.
        /// </summary>
        public override async Task<bool> Handle(OrderItem orderItem)
        {
            var result = InMemoryDataForOrder.GetCustomerInformation(customerId);

            if (result != null && _abstractHandlerChain != null)
            {
                return await _abstractHandlerChain.Handle(orderItem);
            }
            return false;
        }
    }

}
