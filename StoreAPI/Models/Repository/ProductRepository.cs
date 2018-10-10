using System.Collections.Generic;
using System.Linq;

namespace StoreAPI.Models.Repository
{
    public class ProductRepository:IProductRepository
    {
        StoreDbContext ctx;
        public ProductRepository(StoreDbContext c)
        {
            ctx = c;
        }

        public Product GetProduct(int ProductId)
        {
            var product = ctx.Products.FirstOrDefault(b => b.ProductId == ProductId);
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = ctx.Products.ToList();
            return products;
        }

        public void AddProduct(Product product)
        {
            ctx.Products.Add(product);
            int ProductId = ctx.SaveChanges();
        }

        public int DeleteProduct(int ProductId)
        {
            int productId = 0;
            var product = ctx.Products.FirstOrDefault(b => b.ProductId == productId);
            if (product != null)
            {
                ctx.Products.Remove(product);
                productId = ctx.SaveChanges();
            }
            return productId;
        }

        public void UpdateProduct(Product product, int ProductId)
        {
            int productId = 0;
            var productValue = ctx.Products.Find(ProductId);
            if (productValue != null)
            {
                productValue.ProductName = product.ProductName;
                productValue.ProductQuantity = product.ProductQuantity;
                productValue.ProductDescription = product.ProductDescription;

                productId = ctx.SaveChanges();
            }
        }
    }
}
