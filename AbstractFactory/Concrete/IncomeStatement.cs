using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using ClosedXML.Excel;

namespace AbstractFactory.Concrete
{
    public class IncomeStatement : IFinancialReport<IncomeTable>
    {
        public async Task DisplayReport()
        {
            Console.WriteLine("Displaying Report Income Result On the Page");
            await Task.CompletedTask;
        }

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
                // To do Logging
                return false;
            }

            return true;
        }
    }
}
