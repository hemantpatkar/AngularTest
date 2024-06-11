using alpha_bar_service.Models;
using alpha_bar_service.Repository.Interface;

namespace alpha_bar_service.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product_dto> ProductList;
        public ProductRepository()
        {
            ProductList = new List<Product_dto>
            {
                new Product_dto { Product_ID = 1, Product_Name = "Milk" , Drink_Name="Milk Shake"},
                new Product_dto { Product_ID = 2, Product_Name = "Orange" , Drink_Name = "Orange Juice" }
            };
        }


        public Task<Product_dto> GetProductDetails(int ID)
        {
            return Task.FromResult(ProductList.FirstOrDefault(x => x.Product_ID == ID));

        }
    }
}
