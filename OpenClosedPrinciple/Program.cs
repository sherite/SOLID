using AppliedPrinciple.SOLID_PRINCIPLES.OCP;

using System;
namespace SOLID_PRINCIPLES.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice Amount: 10000");

            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");
            
            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}");
            
            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoice : {RInvoiceAmount}");
            
            Invoice TInvoice = new TestInvoice();
            double TInvoiceAmount = TInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Testing Invoice : {TInvoiceAmount}");
            
            Console.ReadKey();
        }
    }
}