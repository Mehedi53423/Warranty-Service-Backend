using Microsoft.AspNetCore.Mvc;
using Warranty.Context;
using Warranty.ViewModels.Products;

namespace Warranty.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Services & Constructor
        private readonly AppDbContext _dbContext;

        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _dbContext.Products.ToList();

            var productList = products.Select(s => new GetProduct
            {
                Id = s.Id,
                Name = s.Name,
                Manufacturer = s.Manufacturer,
                Brand = s.Brand,
                Model = s.Model,
                SerialNumber = s.SerialNumber
            }).ToList();

            return Ok(productList);
        }
    }
}
