namespace SOLID_PRINCIPLES.ISP
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
}

using System;
namespace SOLID_PRINCIPLES.ISP
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}

using System;
namespace SOLID_PRINCIPLES.ISP
{
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}

using System;
namespace SOLID_PRINCIPLES.ISP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Print("Printing");
            hPLaserJetPrinter.Scan("Scanning");
            hPLaserJetPrinter.Fax("Faxing");
            hPLaserJetPrinter.PrintDuplex("PrintDuplex");

            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Print("Printing");
            liquidInkjetPrinter.Scan("Scanning");

            Console.ReadKey();
        }
    }
}