using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Template.Business;

namespace Template.Web.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IGetProductsService _getProductsService;
        public ProductsController(ILogger<ProductsController> logger, IGetProductsService getProductsService)
        {
            _logger = logger;
            _getProductsService = getProductsService;
        }

        [HttpGet("/api/products")]
        public async Task<IActionResult> GetProducts(GetProductsRequest request)
        {
            try
            {
                var products = await _getProductsService.GetProductsAsync(request);
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while fetching Proucts");
                throw;
            }
        }
    }
}
