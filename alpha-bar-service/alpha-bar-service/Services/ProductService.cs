using alpha_bar_service.Models;
using alpha_bar_service.Repository.Interface;
using alpha_bar_service.Services.Interface;

namespace alpha_bar_service.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository _productRepository)
        {
            this.productRepository = _productRepository;

        }

        public Task<Product_dto> GetProductDetails(int ID)
        {
            return this.productRepository.GetProductDetails(ID);
        }
    }
}
