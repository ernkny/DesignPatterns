using AbstractFactory.Abstract;
using AbstractFactory.Entity;

namespace AbstractFactory.Concrete
{
    /// <summary>
    /// Concrete factory for creating instances of CashFlowStatement reports.
    /// Implements the IReportFactory<T> interface for the CashFlowTable data type.
    /// </summary>
    public class CashFlowStatementFactory : IReportFactory<CashFlowTable>
    {
        /// <summary>
        /// Creates and returns an instance of CashFlowStatement.
        /// </summary>
        /// <returns>An instance of CashFlowStatement which is a concrete implementation of IFinancialReport<CashFlowTable>.</returns>
        public IFinancialReport<CashFlowTable> CreateReport()
        {
            return new CashFlowStatement();
        }
    }
}
