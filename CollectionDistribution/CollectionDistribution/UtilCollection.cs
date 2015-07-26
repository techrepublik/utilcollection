using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDistribution
{
    class UtilCollection
    {
        public static List<Product> GetCollectionProducts(List<Product> listProducts, double tenderedAmount)
        {
            var listProds = new List<Product>();
            var tempAmount = 0.00;
            var tempTotal = tenderedAmount;

            if (tenderedAmount > 0)
            {
                foreach (var product in listProducts)
                {
                    if (tempAmount < tenderedAmount)
                    {
                        var p = new Product
                        {
                            ProductName = product.ProductName,
                            Quantity = product.Quantity,
                            Price = tempTotal < product.Price ? tempTotal : product.Price
                        };
                        
                        tempTotal -= product.Price;
                        tempAmount += product.Price;
                        listProds.Add(p);
                    }
                }
            }
            return listProds;
        } 
    }
}
