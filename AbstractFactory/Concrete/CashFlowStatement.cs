using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using ClosedXML.Excel;

namespace AbstractFactory.Concrete
{
    /// <summary>
    /// Concrete implementation of IFinancialReport<T> for cash flow statements.
    /// Handles the creation and display of cash flow reports using the CashFlowTable type.
    /// </summary>
    public class CashFlowStatement : IFinancialReport<CashFlowTable>
    {
        /// <summary>
        /// Asynchronously displays the generated cash flow report.
        /// </summary>
        /// <returns>A task representing the asynchronous display operation.</returns>
        public async Task DisplayReport()
        {
            Console.WriteLine("Displaying Report Cash Flow Result On the Page");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Asynchronously generates a cash flow report based on provided CashFlowTable data.
        /// </summary>
        /// <param name="cashFlow">The cash flow data used to generate the report.</param>
        /// <returns>A task representing the asynchronous report generation operation, containing a boolean result.</returns>
        public async Task<bool> GenerateReport(CashFlowTable cashFlow)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var workbook = new XLWorkbook())
                    {
                        /// Simulation for creation cash flow excel report
                        workbook.SaveAs("CashFlowStatement.xlsx");
                    }
                });
            }
            catch (Exception exception)
            {
                // Logging should be implemented here to handle the exception
                return false;
            }

            return true;
        }
    }
}
