namespace AppliedPrinciple
{
   
    public class Customer
    {
        public void Purchase(IPricing pricing)
        {
            decimal price = pricing.GetPrice();
            // Code for make the purchase.
        }
    }

    public interface IPricing
    {
        decimal GetPrice();

    }

    public class Product : IPricing
    {
        public decimal Price { get; set; }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
