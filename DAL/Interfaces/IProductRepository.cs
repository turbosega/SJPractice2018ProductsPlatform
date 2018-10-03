using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<int> Create(Product product);
        Task<int> Update(Product product);
        Task<int> Delete(int id);
    }
}
