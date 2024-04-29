using AbstractFactory.Abstract;
using AbstractFactory.Entity;
using ClosedXML.Excel;

namespace AbstractFactory.Concrete
{
    public class CashFlowStatement : IFinancialReport<CashFlowTable>
    {
        public async Task DisplayReport()
        {
            Console.WriteLine("Displaying Report Cash Flow Result On the Page");
            await Task.CompletedTask;
        }

        public async Task<bool> GenerateReport(CashFlowTable cashFlow)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Cash Flow Statement");
                        worksheet.Cell("A1").Value = "Description";
                        worksheet.Cell("B1").Value = "Amount";

                        worksheet.Cell("A2").Value = "Operating Activities";
                        worksheet.Cell("B2").Value = cashFlow.OperatingActivities;

                        worksheet.Cell("A3").Value = "Investing Activities";
                        worksheet.Cell("B3").Value = cashFlow.InvestingActivities;

                        worksheet.Cell("A4").Value = "Financing Activities";
                        worksheet.Cell("B4").Value = cashFlow.FinancingActivities;

                        worksheet.Cell("A5").Value = "Net Increase in Cash";
                        worksheet.Cell("B5").Value = cashFlow.NetIncreaseInCash;

                        worksheet.Cell("A6").Value = "Cash at Beginning of Period";
                        worksheet.Cell("B6").Value = cashFlow.CashAtBeginningOfPeriod;

                        worksheet.Cell("A7").Value = "Cash at End of Period";
                        worksheet.Cell("B7").Value = cashFlow.CashAtEndOfPeriod;

                        workbook.SaveAs("CashFlowStatement.xlsx");
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
