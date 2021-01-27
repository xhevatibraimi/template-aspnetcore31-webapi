using System.Threading.Tasks;

namespace Template.Business
{
    public interface IGetProductsService
    {
        Task<GetProductsResponse> GetProductsAsync(GetProductsRequest request);
    }
}
