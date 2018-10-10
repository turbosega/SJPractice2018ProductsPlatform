using System.Collections.Generic;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrder(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
