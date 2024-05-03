using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Abstract
{
    public interface IPaymentGateway
    {
        Task<bool> ProcessPayment(decimal amount);
    }
}
