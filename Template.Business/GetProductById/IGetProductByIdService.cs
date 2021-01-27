using System.Threading.Tasks;

namespace Template.Business
{
    public interface IGetProductByIdService
    {
        Task<GetProductByIdResponse> GetProducByIdAsync(GetProductByIdRequest request);
    }
}
