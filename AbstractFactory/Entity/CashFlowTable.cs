using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entity
{
    public class CashFlowTable
    {
        public decimal OperatingActivities { get; set; }
        public decimal InvestingActivities { get; set; }
        public decimal FinancingActivities { get; set; }
        public decimal NetIncreaseInCash { get; set; }
        public decimal CashAtBeginningOfPeriod { get; set; }
        public decimal CashAtEndOfPeriod { get; set; }
    }
}
