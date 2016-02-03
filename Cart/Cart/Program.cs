using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "milk", Price = 1.2F });
            products.Add(new Product { Name = "beer", Price = 2.2F });
            products.Add(new Product { Name = "fish", Price = 3.2F });
            products.Add(new Product { Name = "cheese", Price = 4.2F });

            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
