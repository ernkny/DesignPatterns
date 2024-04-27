using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Concrete.Entity
{
    /// <summary>
    /// Customer Information
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        ///
        public string Email { get; set; }
        /// <summary>
        /// Street name and number of the address.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// City name of the address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State or province of the address.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Postal code of the address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country name of the address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Description of the address.
        /// </summary>
        public string AddressDescription { get; set; }
    }
}
