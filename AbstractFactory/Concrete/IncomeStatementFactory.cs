using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    /// <summary>
    /// Concrete factory for creating instances of IncomeStatement reports.
    /// Implements the IReportFactory<T> interface for the IncomeTable data type.
    /// </summary>
    public class IncomeStatementFactory : IReportFactory<IncomeTable>
    {
        /// <summary>
        /// Creates and returns an instance of IncomeStatement.
        /// </summary>
        /// <returns>An instance of IncomeStatement which is a concrete implementation of IFinancialReport<IncomeTable>.</returns>
        public IFinancialReport<IncomeTable> CreateReport()
        {
            return new IncomeStatement();
        }
    }
}
