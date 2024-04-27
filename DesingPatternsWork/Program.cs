using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using Chain_of_Responsibility.Concrete.ChainOfResponsibilityPattern;
using Chain_of_Responsibility.Concrete.Entity;
using FacadeDP.Concrete;
using FactoryMethodDP.Concrete;
using StrategyDP.Abstract;
using StrategyDP.Concrete;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesingPatternsWork
{
    internal static class Program
    {
        async static Task Main(string[] args)
        {
            var order = new Order();
            order.Items.Add(new OrderItem() { ProductId = 1, Quantity = 1, UnitPrice = 100 });
            var orderItem = order.Items.First();
            var stockControl = new StockControl();
            var addressControl = new  AddressControl(1);
            var paymentControl= new PaymentControl();
            await stockControl.SetNext(addressControl);
            await addressControl.SetNext(paymentControl);
            await stockControl.Handle(orderItem);
            await addressControl.Handle(orderItem);
            var orderResult = await paymentControl.Handle(orderItem);
            Console.WriteLine(orderResult);



            #region Chain of Responsibility Pattern Works

            #endregion
            #region AbstractFactory Design Pattern Works
            //IFurnitureFactory ModernChair = new ModernChairFactory();
            //IFurnitureFactory ArtDecoTable = new ArtDecoTableFactory();
            //AbstractFactoryForFurnite abstractFactoryForModernChair = new AbstractFactoryForFurnite(ModernChair);
            //AbstractFactoryForFurnite abstractFactoryForArtDecoTable = new AbstractFactoryForFurnite(ArtDecoTable);
            //Console.WriteLine(abstractFactoryForModernChair.GetTypeOfFurniture() + " " + abstractFactoryForModernChair.GetNameOfFurniture());
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(abstractFactoryForArtDecoTable.GetTypeOfFurniture() + " " + abstractFactoryForArtDecoTable.GetNameOfFurniture());

            //Console.ReadKey();
            #endregion

            #region Facade Design Pattern Works
            //TumControl tmc = new TumControl();
            //Customer c = new Customer("Eren Kınay");
            //bool sonuc = tmc.IsEligible(c,12000);
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
            //string message = "Important Message Included";
            //while (true)
            //{
            //    LoggerFactory loggerfactory = new LoggerFactory();
            //    var logger=loggerfactory.CreateLogger(LoggerType.Database);
            //    logger.log(message);
            //    Thread.Sleep(2000);
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
