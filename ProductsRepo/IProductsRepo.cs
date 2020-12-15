using System.Collections.Generic;
using ProductAPI;

namespace ProductsRepo
{
    public interface IProductsRepo
    {
        List<Products> GetProducts();

    }
}