using alpha_bar_service.Models;

namespace alpha_bar_service.Repository.Interface
{
    public interface IProductRepository
    {
        Task<Product_dto> GetProductDetails(int ID);
    }
}
