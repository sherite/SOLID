using System;
using System.Collections.Generic;

namespace Solid_SRP.AppliedPrinciple
{
    #region EntitiesLayer
    public class Order
    {
        public Guid Id { get; }
        public Customer Customer { get; }
        public IEnumerable<OrderLine> Lines { get; }
        public decimal TotalAmount { get; }
        public decimal Taxes { get; }
    }
    #endregion EntitiesLayer

    #region BusinessRulesLayer
    public class OrderOperations
    {
        public void AddLine(Product product, int quantity) { }
        public void RemoveLine(OrderLine line) { }
    }

    public class OrderService
    {
        public decimal CalculateAmount(Order order) { return 0; }
        public decimal CalculateTaxes(Order order) { return 0; }
        public Invoice CreateInvoice(Order order) { return new Invoice(); }
    }   

    public class OrderValidator
    {
        public ValidationResult Validate(Order order) { return new ValidationResult(); }
    }
    #endregion

    #region DataAccessLayer
    public class OrderStore
    {
        public void Load(Guid id) { }
        public void Save(Order order) { }
    }
    #endregion

    #region ApplicationLayer
    public class OrderPrint
    {
        public void ToPdf() { }
        public void ToPrinter() { }
        public void ToFile() { }
    }
    #endregion
}