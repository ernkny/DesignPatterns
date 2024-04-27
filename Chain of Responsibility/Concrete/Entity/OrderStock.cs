using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.Entity
{
    public class OrderStock
    {
        /// <summary>
        /// Product identifier for the item.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Quantity of the total item that have.
        /// </summary>
        public int TotalQuantity { get; set; }
    }
}
