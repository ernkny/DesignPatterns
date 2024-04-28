using Chain_of_Responsibility.Abstract;
using Chain_of_Responsibility.Concrete.Entity;
using Chain_of_Responsibility.InMemoryContext;

namespace Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern
{
    /// <summary>
    /// Handles stock control in a chain of responsibility pattern implementation.
    /// This class checks if the required quantity of a product is available in stock before passing the request to the next handler in the chain.
    /// </summary>
    public class StockControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;

        /// <summary>
        /// Sets the next handler in the chain of responsibility.
        /// </summary>
        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Processes an order item by checking stock availability and, if sufficient stock exists,
        /// passing the order item to the next handler in the chain.
        /// </summary>
        public override async Task<bool> Handle(OrderItem orderItem)
        {
            var result = InMemoryDataForOrder.GetAllProductTotalQuantity();
            if (_abstractHandlerChain != null && result.Count(x => x.ProductId == orderItem.ProductId) >= orderItem.Quantity)
            {
                return await _abstractHandlerChain.Handle(orderItem);
            }

            return false;
        }
    }
}
