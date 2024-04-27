using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.Entity
{

    /// <summary>
    /// Represents an item within an order.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Product identifier for the item.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Price per unit of the item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Quantity of the item ordered.
        /// </summary>
        public int Quantity { get; set; }
    }
}
