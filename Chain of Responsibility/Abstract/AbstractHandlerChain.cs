using Chain_of_Responsibility.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Abstract
{
    /// <summary>
    /// Represents the base class for handling operations in a chain of responsibility.
    /// Each handler in the chain can process an OrderItem or pass it to the next handler.
    /// </summary>
    public abstract class AbstractHandlerChain
    {
        /// <summary>
        /// Sets the next handler in the chain of responsibility.
        /// This method should link this handler to another, forming a chain where an OrderItem can be passed along if not fully processed by this handler.
        public abstract Task SetNext(AbstractHandlerChain abstractHandlerChain);

        /// <summary>
        /// Handles the processing of an OrderItem.
        /// This method should implement the specific handling logic of the derived handler class. If the item cannot be fully processed, it may be passed to the next handler in the chain.
        public abstract Task<bool> Handle(OrderItem orderItem);
    }

}
