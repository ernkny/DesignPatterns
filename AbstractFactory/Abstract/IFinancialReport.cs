using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    /// <summary>
    /// Defines a generic interface for financial reports, allowing for report generation and display.
    /// The type parameter T represents the data structure used for report generation.
    /// </summary>
    public interface IFinancialReport<T>
    {
        /// <summary>
        /// Asynchronously generates a report based on the provided export data.
        /// Returns a boolean indicating success or failure.
        /// </summary>
        /// <param name="ExportData">The export data of type T used to generate the report.</param>
        /// <returns>A task representing the asynchronous operation, containing a boolean result.</returns>
        Task<bool> GenerateReport(T ExportData);

        /// <summary>
        /// Asynchronously displays the report content.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DisplayReport();
    }
}
