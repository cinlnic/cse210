using System;

class Program
{
   static void Main(string[] args)
   {
      List<Order> orders = new List<Order>();

      Order order1 = new Order();
      Product order1Prod1 = new Product("Book of Mormon", 1, 35, 2);
      Product order1Prod2 = new Product("Temple Bag", 2, 25, 1);
      order1.SetProduct(order1Prod1);
      order1.SetProduct(order1Prod2);
      Address address1 = new Address("1515 1st St", "Nampa", "ID", "USA");
      Customer cust1 = new Customer("John Smith", address1);
      order1.SetCustomer(cust1);

      Order order2 = new Order();
      Product order2Prod1 = new Product("Temple Dress", 101, 75, 1);
      Product order2Prod2 = new Product("Journal", 104, 25, 1);
      order2.SetProduct(order2Prod1);
      order2.SetProduct(order2Prod2);
      Address address2 = new Address("18185 Royal Way", "Montreal", "Quebec", "Canada");
      Customer cust2 = new Customer("Lucy Smith", address2);
      order2.SetCustomer(cust2);

      orders.Add(order1);
      orders.Add(order2);

      foreach (Order order in orders)
      {
         Console.WriteLine($"\nOrder:");
         order.ShippingLabel(order.GetCustomer());
         order.PackingLabel(order.GetProduct());
         Console.WriteLine($"Total: ${order.TotalPrice()}");
      }

   }
}