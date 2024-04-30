using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    /// <summary>
    /// Defines a factory interface for creating financial report instances.
    /// This interface supports the Abstract Factory design pattern.
    /// </summary>
    public interface IReportFactory<T>
    {
        /// <summary>
        /// Creates an instance of a financial report that handles data of type T.
        /// </summary>
        /// <returns>An instance of IFinancialReport<T>.</returns>
        IFinancialReport<T> CreateReport();
    }
}
