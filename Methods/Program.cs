using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("--------------Methods-------------");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("armut", "yeşil armut", 12, 10);
            basketManager.Add2("elma", "yeşil elma", 12, 10);
            basketManager.Add2("karpuz", "Diyarbakır karpuzu", 12, 10);
        }
    }
}
