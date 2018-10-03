using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderRepository
    {
        Task<IList<Order>> GetAll();
        Task<Order> GetById(int id);
        Task<int> Create(Order order);
        Task<int> Update(Order order);
        Task<int> Delete(int id);
    }
}
