using Chain_of_Responsibility.Concrete.Entity;

namespace Chain_of_Responsibility.InMemoryContext
{

    /// <summary>
    /// InMemort data simulation for order process
    /// </summary>
    public static class InMemoryDataForOrder
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Retrieves the total quantity available for all products in the inventory.
        /// </summary>
        /// <returns>An IEnumerable of ProductStock, each containing a product ID and its total available quantity.</returns>
        public static IEnumerable<ProductStock> GetAllProductTotalQuantity()
        {
            return new List<ProductStock>()
        {
            new ProductStock() {ProductId = 1, TotalQuantity = 10},
            new ProductStock() {ProductId = 2, TotalQuantity = 8},
            new ProductStock() {ProductId = 3, TotalQuantity = 0},
        };
        }

        /// <summary>
        /// Fetches customer information based on a customer ID.
        /// </summary>
        /// <param name="customerId">The ID of the customer to retrieve information for.</param>
        /// <returns>A Customer object containing detailed information about the customer, or null if the customer is not found.</returns>
        public static Customer GetCustomerInformation(int customerId)
        {
            var result = new List<Customer>()
                    {
                        new Customer()
                        {
                            CustomerId = 1,
                            FirstName = "Eren",
                            LastName = "Kınay",
                            Email = "eren.kinay@example.com",
                            Street = "1234 Coding Ave",
                            City = "Istanbul",
                            State = "TR",
                            PostalCode = "34000",
                            Country = "Turkey",
                            AddressDescription = "Located near the central business district."
                        }
                    }.Find(x => x.CustomerId == customerId);

            if (result is null)
            {
                throw new ArgumentNullException(customerId.ToString(), " Customer doesn't exist");
            }
            return result;
        }

        /// <summary>
        /// Simulates a payment verification check by calling an external API.
        /// </summary>
        /// <returns>True if the payment is verified (randomly determined), False otherwise.</returns>
        public static bool PaymentCheckedFromAPI()
        {
            // Simulates an API call to check payment status, randomly returns True or False
            return _random.Next(0, 2) == 1;
        }
    }
}
