using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductsRepo _productsRepo;

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger, IProductsRepo repo)
        {
            _logger = logger;
            _productsRepo = repo;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
           return _productsRepo.GetProducts().ToArray();
        }
    }
}
