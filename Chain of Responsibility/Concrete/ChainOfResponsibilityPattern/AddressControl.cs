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
    public class AddressControl : AbstractHandlerChain
    {
        private AbstractHandlerChain _abstractHandlerChain;
        private  int customerId { get;  set; }
        public AddressControl(int customerId)
        {
            this.customerId = customerId;

        }

        public override async Task SetNext(AbstractHandlerChain abstractHandlerChain)
        {
            _abstractHandlerChain = abstractHandlerChain;
            await Task.CompletedTask;
        }
        public override async Task<bool> Handle(OrderItem orderItem)
        {
            var result = InMemoryDataForOrder.GetCustomerInformation(customerId);
            if (result is not null)
            {
                await _abstractHandlerChain.Handle(orderItem);
            }
            return false;
        }
    }
}
