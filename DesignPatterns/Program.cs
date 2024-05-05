using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using AbstractFactory.Entity;
using AdapterDP.Abstract;
using AdapterDP.Concrete;
using Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern;
using Chain_of_Responsibility.Concrete.Entity;
using FacadeDP.Concrete;
using FactoryMethodDP.Concrete;
using StrategyDP.Concrete;


#region Chain of Responsibility Pattern Works

//var order = new Order();
//order.Items.Add(new OrderItem() { ProductId = 1, Quantity = 1, UnitPrice = 100 });
//var orderItem = order.Items.First();

//var stockControl = new StockControl();
//var addressControl = new AddressControl(1);
//var paymentControl = new PaymentControl();

//await stockControl.SetNext(addressControl);
//await addressControl.SetNext(paymentControl);

//await stockControl.Handle(orderItem);
//await addressControl.Handle(orderItem);
//var orderResult = await paymentControl.Handle(orderItem);
//Console.WriteLine(orderResult ? "Order is okay" : "Order is not okay");

#endregion

#region AbstractFactory Design Pattern Works
//var incomeTable = new IncomeTable
//{
//    NetSales = 150000,
//    CostOfGoodsSold = 50000,
//    GrossProfit = 100000
//};

//var cashFlow = new CashFlowTable
//{
//    OperatingActivities = 50000m,
//    InvestingActivities = -20000m,
//    FinancingActivities = 30000m,
//    CashAtBeginningOfPeriod = 10000m
//};

//IReportFactory<IncomeTable> factoryForIncome = new IncomeStatementFactory();
//IFinancialReport<IncomeTable> reportForIncome = factoryForIncome.CreateReport();
//await reportForIncome.GenerateReport(incomeTable);
//await reportForIncome.DisplayReport();

//IReportFactory<CashFlowTable> factoryForCashFlow = new CashFlowStatementFactory();
//IFinancialReport<CashFlowTable> reportForCashFlow = factoryForCashFlow.CreateReport();
//await reportForCashFlow.GenerateReport(cashFlow);
//await reportForCashFlow.DisplayReport();

#endregion

#region Adapter Pattern Works

//IPaymentGateway paymentGateway;

//paymentGateway = new PayPalAdapter(new PayPalPayment());
//Console.WriteLine(await paymentGateway.ProcessPayment(100));

//paymentGateway = new StripeAdapter(new StripePayment());
//Console.WriteLine(await paymentGateway.ProcessPayment(150));
#endregion

#region Facade Design Pattern Works
//TumControl tmc = new TumControl();
//FacadeDP.Concrete.Customer c = new FacadeDP.Concrete.Customer("Eren Kınay");
//bool sonuc = tmc.IsEligible(c, 12000);
//Console.WriteLine("\n" + c.Name +
//       " İşlem Sonucunuz: " + (sonuc ? "Kabul Edildi" : "Kabul Edilmedi"));

//Console.ReadKey();
#endregion

#region Strategy Design Pattern Works
//SortedList Kisiler = new SortedList();
//Kisiler.Add("Eren");
//Kisiler.Add("Fatih");
//Kisiler.Add("Refik");
//Kisiler.Add("Derya");
//Kisiler.Add("Eray");
//Kisiler.SetSortStrategy(new QuickSort());
//Kisiler.Sort();
//Kisiler.SetSortStrategy(new ShellSort());
//Kisiler.Sort();
//Kisiler.SetSortStrategy(new MergeSort());
//Kisiler.Sort();

//Console.ReadKey();
#endregion

#region Factory Method Design Pattern Works

var message = "Important Message Included";
while (true)
{
    var loggerfactory = new LoggerFactory();
    var logger = loggerfactory.CreateLogger(LoggerType.Database);
    await logger.log(message);
    Thread.Sleep(2000);
}

#endregion
