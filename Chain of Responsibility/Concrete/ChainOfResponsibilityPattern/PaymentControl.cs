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
    public class PaymentControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;

        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }

        public override async Task<bool> Handle(OrderItem orderItem)
        {
            return await Task.Run(() => InMemoryDataForOrder.PaymentCheckedFromAPI()) ;
        }

    }
}
