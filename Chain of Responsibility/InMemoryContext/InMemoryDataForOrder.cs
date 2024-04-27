using Chain_of_Responsibility.Concrete.Entity;

namespace Chain_of_Responsibility.InMemoryContext
{
    internal static class InMemoryDataForOrder
    {
        private static readonly Random _random = new Random();
        public static IEnumerable<OrderStock> GetAllProductTotalQuantity()
        {
            return new List<OrderStock>()
            {
                new OrderStock() {ProductId=1,TotalQuantity=10},
                new OrderStock() {ProductId=2,TotalQuantity=8},
                new OrderStock() {ProductId=3,TotalQuantity=0},
            };
        }

        public static Customer GetCustomerInformation(int customerId)
        {
            return new List<Customer>(){ new Customer()
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
            }}.First(x=>x.CustomerId== customerId);
        }

        public static bool PaymentCheckedFromAPI()
        {
            return _random.Next(0, 2) == 1;
        }


    }
}
