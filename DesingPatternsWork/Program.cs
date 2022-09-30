using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using FacadeDP.Concrete;
using FactoryMethodDP.Concrete;
using StrategyDP.Abstract;
using StrategyDP.Concrete;
using System;
using System.Threading;

namespace DesingPatternsWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AbstractFactory Design Pattern Çalışma
            IFurnitureFactory ModernChair = new ModernChairFactory();
            IFurnitureFactory ArtDecoTable = new ArtDecoTableFactory();
            AbstractFactoryForFurnite abstractFactoryForModernChair = new AbstractFactoryForFurnite(ModernChair);
            AbstractFactoryForFurnite abstractFactoryForArtDecoTable = new AbstractFactoryForFurnite(ArtDecoTable);
            Console.WriteLine(abstractFactoryForModernChair.GetTypeOfFurniture() + " " + abstractFactoryForModernChair.GetNameOfFurniture());
            Console.WriteLine("-----------------------------");
            Console.WriteLine(abstractFactoryForArtDecoTable.GetTypeOfFurniture() + " " + abstractFactoryForArtDecoTable.GetNameOfFurniture());

            Console.ReadKey();
            #endregion

            #region Facade Design Pattern Çalışma
            //TumControl tmc = new TumControl();
            //Customer c = new Customer("Eren Kınay");
            //bool sonuc = tmc.IsEligible(c,12000);
            //Console.WriteLine("\n" + c.Name +
            //       " İşlem Sonucunuz: " + (sonuc ? "Kabul Edildi" : "Kabul Edilmedi"));

            //Console.ReadKey();
            #endregion

            #region Strategy Design Pattern Çalışma
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

            #region Factory Method Design Pattern Çalışma
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
