using System.Collections.Generic;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Interfaces
{
    public interface IOrderProductRepository
    {
        IEnumerable<OrderProduct> GetAllOrderProducts();
        OrderProduct GetOrderProduct(int id);
        void AddOrderProduct(OrderProduct orderProduct);
        void UpdateOrderProduct(OrderProduct orderProduct);
        void DeleteOrderProduct(int id);
    }
}
