using DiWithUnity.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWithUnity.Services
{
    public class ProductsService:IProductsService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product(){Name="Laptop",Price=1500 },
                new Product(){Name="Xbox",Price=400},

            };
        }
    }
}
