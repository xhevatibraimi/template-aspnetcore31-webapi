using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Business.Exceptions;

namespace Template.Business.EF
{
    public class GetProductByIdService : IGetProductByIdService
    {
        private readonly List<GetProductByIdResponse> _products;

        public GetProductByIdService()
        {
            _products = new List<GetProductByIdResponse>
            {
                new GetProductByIdResponse {
                    Id = 1,
                    DisplayName= "bananna",
                    Categories = new List<string>{ "fruits", "healthy" }
                },
                new GetProductByIdResponse {
                    Id = 2,
                    DisplayName= "tomato",
                    Categories = new List<string>{ "vegetables", "healthy" }
                },
                new GetProductByIdResponse {
                    Id = 3,
                    DisplayName= "Pepsi",
                    Categories = new List<string>{ "drinks", "cola" }
                },
                new GetProductByIdResponse {
                    Id = 4,
                    DisplayName= "Coca Cola",
                    Categories = new List<string>{ "drinks", "cola" }
                }
            };
        }

        public Task<GetProductByIdResponse> GetProducByIdAsync(GetProductByIdRequest request)
        {
            var product = _products.FirstOrDefault(x => x.Id == request.Id);
            if (product == null)
            {
                throw new ProductNotFoundException("product not found");
            }

            return Task.FromResult(product);
        }
    }
}
