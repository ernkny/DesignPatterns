using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.Entity
{
    public class Order
    {
        /// <summary>
        /// Constructor to initialize the list of items.
        /// </summary>
        public Order()
        {
            Items = new List<OrderItem>();
        }

        /// <summary>
        /// Unique identifier for the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Identifier for the customer placing the order.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Date and time the order was placed.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// List of items in the order.
        /// </summary>
        public List<OrderItem> Items { get; set; }
    }

}

