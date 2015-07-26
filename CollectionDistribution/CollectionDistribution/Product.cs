using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDistribution
{
    class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public static List<Product> PopulateProducts()
        {
            var list = new List<Product>
            {
                new Product() {Price = 100, ProductName = "Potato", Quantity = 50},
                new Product() {Price = 250, ProductName = "Rice", Quantity = 100},
                new Product() {Price = 300, ProductName = "Bacon", Quantity = 10},
                new Product() {Price = 350, ProductName = "Sardinas", Quantity = 20},
                new Product() {Price = 40, ProductName = "Ballpen", Quantity = 35}
            };
            return list;
        } 
    }
}
