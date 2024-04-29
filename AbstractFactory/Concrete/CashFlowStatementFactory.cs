using AbstractFactory.Abstract;
using AbstractFactory.Entity;

namespace AbstractFactory.Concrete
{
    public class CashFlowStatementFactory : IReportFactory<CashFlowTable>
    {
        public IFinancialReport<CashFlowTable> CreateReport()
        {
            return new CashFlowStatement();
        }
    }
}
