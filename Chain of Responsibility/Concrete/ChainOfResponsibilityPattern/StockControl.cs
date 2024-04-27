using Chain_of_Responsibility.Abstract;
using Chain_of_Responsibility.Concrete.Entity;
using Chain_of_Responsibility.InMemoryContext;

namespace Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern
{
    public class StockControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;
        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }
        public override async Task<bool> Handle(OrderItem orderItem)
        {
            var result = InMemoryDataForOrder.GetAllProductTotalQuantity();
            if (_abstractHandlerChain != null && result.Count(x=>x.ProductId == orderItem.ProductId)>= orderItem.Quantity)
            {
                return await _abstractHandlerChain.Handle(orderItem);
            }

            return false;
        }

    }
}
