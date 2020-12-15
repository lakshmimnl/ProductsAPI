using System;
using System.Collections.Generic;
using ProductAPI;

namespace ProductsRepo
{
    public class ProductsRepo : IProductsRepo
    {
        public List<Products> GetProducts()
        {
            var products = new List<Products>();
            products.Add(new Products { ProductRate = 1.5, ProductName = "1 year Fixed" });
            products.Add(new Products { ProductRate = 2.5, ProductName = "2 year Fixed" });
            return products;
          
        }
    }
}
