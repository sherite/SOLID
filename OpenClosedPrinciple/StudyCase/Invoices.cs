namespace StudyCase
{
    namespace SOLID_PRINCIPLES.OCP
    {
        public class Invoice
        {
            public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
            {
                var finalAmount = 0d;

                if (invoiceType == InvoiceType.FinalInvoice)
                {
                    finalAmount = amount - 100;
                }
                else if (invoiceType == InvoiceType.ProposedInvoice)
                {
                    finalAmount = amount - 50;
                }
                return finalAmount;
            }
        }
        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        };
    }
}