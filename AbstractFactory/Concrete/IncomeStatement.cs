using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using ClosedXML.Excel;

namespace AbstractFactory.Concrete
{
    /// <summary>
    /// Concrete implementation of IFinancialReport<T> for income statements.
    /// Handles the creation and display of income statements using the IncomeTable type.
    /// </summary>
    public class IncomeStatement : IFinancialReport<IncomeTable>
    {
        /// <summary>
        /// Asynchronously displays the generated income statement report.
        /// </summary>
        /// <returns>A task representing the asynchronous display operation.</returns>
        public async Task DisplayReport()
        {
            Console.WriteLine("Displaying Report Income Result On the Page");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Asynchronously generates an income statement report based on provided IncomeTable data.
        /// </summary>
        /// <param name="table">The income data used to generate the report.</param>
        /// <returns>A task representing the asynchronous report generation operation, containing a boolean result.</returns>
        public async Task<bool> GenerateReport(IncomeTable table)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var workbook = new XLWorkbook())
                    {
                        /// Simulation for creation income statement excel report
                        workbook.SaveAs("IncomeStatement.xlsx");
                    }
                });
            }
            catch (Exception exception)
            {
                // Logging can be implemented here to handle the exception
                return false;
            }
            return true;
        }
    }
}
