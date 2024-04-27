using Chain_of_Responsibility.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Abstract
{
    public abstract class AbstractHandlerChain
    {
        public abstract Task SetNext(AbstractHandlerChain abstractHandlerChain);
        public abstract Task<bool> Handle(OrderItem orderItem);
    }
}
