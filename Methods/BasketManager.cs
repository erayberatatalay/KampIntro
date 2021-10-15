using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name); 
        }
        public void Add2(string productName, string description, double price, int StockAmount)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}
