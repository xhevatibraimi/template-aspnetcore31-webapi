using System.Collections.Generic;
using System.Threading.Tasks;

namespace Template.Business.EF
{
    public class GetProductsService : IGetProductsService
    {
        private readonly List<ProductViewModel> _products;

        public GetProductsService()
        {
            _products = new List<ProductViewModel>
            {
                new ProductViewModel {
                    Id = 1,
                    DisplayName= "bananna",
                    Categories = new List<string>{ "fruits", "healthy" }
                },
                new ProductViewModel {
                    Id = 2,
                    DisplayName = "tomato",
                    Categories = new List<string>{ "vegetables", "healthy" }
                },
                new ProductViewModel {
                    Id = 3,
                    DisplayName= "Pepsi",
                    Categories = new List<string>{ "drinks", "cola" }
                },
                new ProductViewModel {
                    Id = 3,
                    DisplayName= "Coca Cola",
                    Categories = new List<string>{ "drinks", "cola" }
                }
            };
        }

        public Task<GetProductsResponse> GetProductsAsync(GetProductsRequest request)
        {
            var response = new GetProductsResponse
            {
                Products = _products
            };

            return Task.FromResult(response);
        }
    }
}
