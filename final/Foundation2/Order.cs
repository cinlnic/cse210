public class Order
{
   private List<Product> _products = new List<Product>();
   private Customer _customer;

   public Order() { }

   public void SetProduct(Product product)
   {
      _products.Add(product);
   }

   public List<Product> GetProduct()
   {
      return _products;
   }

   public void SetCustomer(Customer customer)
   {
      _customer = customer;
   }

   public Customer GetCustomer()
   {
      return _customer;
   }

   public int TotalPrice()
   {
      int productTotal = 0;

      foreach (Product product in _products)
      {
         productTotal += product.Price();
      }

      return productTotal + Shipping();
   }

   private int Shipping()
   {
      int shipping = 5;

      if (!_customer.InUSA())
      {
         shipping = 35;
      }

      return shipping;
   }

   public void PackingLabel(List<Product> products)
   {
      Console.WriteLine("Packing Label: ");
      foreach (Product product in products)
      {
         Console.WriteLine($"{product.GetProductId()} {product.GetName()}");
      }
   }

   public void ShippingLabel(Customer customer)
   {
      Console.WriteLine($"{customer.GetName()}");
      Console.WriteLine($"{customer.GetAddress().GetStreet()}");
      Console.WriteLine($"{customer.GetAddress().GetCity()}, {customer.GetAddress().GetState()}");
      Console.WriteLine($"{customer.GetAddress().GetCountry()}");
   }
}