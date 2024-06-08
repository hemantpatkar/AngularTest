using alpha_bar_service.Models;
namespace alpha_bar_service.Services.Interface
{
    public interface IProductService
    {
        Task<Product_dto> GetProductDetails(int ID);
    }
}
