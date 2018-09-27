using System.Collections.Generic;

namespace StoreAPI.Models.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product ProductValue);
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int ProductId);
        int DeleteProduct(int ProductId);
        void UpdateProduct(Product ProductValue, int ProductId);
    }
}
