using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple.StudyCase
{
    public class Order
    {
        public Guid Id { get; }
        public Customer Customer { get; }
        public IEnumerable<OrderLine> Lines { get; }
        public decimal TotalAmount { get; }
        public decimal Taxes { get; }
        public void AddLine(Product product, int quantity) { }
        public void RemoveLine(OrderLine line) { }
        public decimal CalculateAmount(Order order) { return 0; }
        public decimal CalculateTaxes(Order order) { return 0; }
        public Invoice CreateInvoice() { return null; }
        public bool Validate() { return true; }
        public void Load() { }
        public void Save() { }
        public void Print() { }
    }
}

#region Definitions

namespace SingleResponsibilityPrinciple
{
    public class Customer { }
    public class OrderLine { }
    public class Product { }
    public class Invoice { }
    public class ValidationResult { }
}

#endregion Definitions