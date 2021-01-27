using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Template.Business;
using Template.Business.Exceptions;

namespace Template.Web.Controllers
{
    public class ProductByIdController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IGetProductByIdService _getProductByIdService;
        public ProductByIdController(ILogger<ProductsController> logger, IGetProductByIdService getProductByIdService)
        {
            _logger = logger;
            _getProductByIdService = getProductByIdService;
        }

        [HttpGet("/api/products/{id:min(1)}")]
        public async Task<IActionResult> GetProducts(int id)
        {
            try
            {
                var products = await _getProductByIdService.GetProducByIdAsync(new GetProductByIdRequest { Id = id });
                return Ok(products);
            }
            catch (ProductNotFoundException ex)
            {
                _logger.LogError(ex, $"Product was not found for the given id '{id}'");
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while fetching Proucts");
                throw;
            }
        }
    }
}
