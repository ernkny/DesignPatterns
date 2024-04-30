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
                        var worksheet = workbook.Worksheets.Add("Income Statement");
                        worksheet.Cell("A1").Value = "Description";
                        worksheet.Cell("B1").Value = "Amount";

                        worksheet.Cell("A2").Value = "Net Sales";
                        worksheet.Cell("B2").Value = table.NetSales;

                        worksheet.Cell("A3").Value = "Cost of Goods Sold";
                        worksheet.Cell("B3").Value = table.CostOfGoodsSold;

                        worksheet.Cell("A4").Value = "Gross Profit";
                        worksheet.Cell("B4").Value = table.GrossProfit;

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
