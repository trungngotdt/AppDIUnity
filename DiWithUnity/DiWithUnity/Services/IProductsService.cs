using DiWithUnity.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWithUnity.Services
{
   public interface IProductsService
    {
        IEnumerable<Product> GetProducts();

    }
}
