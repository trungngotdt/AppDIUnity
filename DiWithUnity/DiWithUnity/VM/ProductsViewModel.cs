using DiWithUnity.M;
using DiWithUnity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWithUnity.VM
{
    public class ProductsViewModel
    {
        private readonly IProductsService _productsService;
        public IEnumerable<Product> Products { get; set; }
        public ProductsViewModel(IProductsService productsService)
        {
            _productsService = productsService;// new ProductsService();
            DownloadProducts();
        }

        public void DownloadProducts()
        {
            Products = _productsService.GetProducts();
            //throw new NotImplementedException();
        }
    }
}
