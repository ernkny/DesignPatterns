using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class IncomeStatementFactory : IReportFactory<IncomeTable>
    {
        public IFinancialReport<IncomeTable> CreateReport()
        {
            return new IncomeStatement();
        }
    }
}
