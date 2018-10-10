using System.Collections.Generic;
using System.Linq;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class OrderProductRepository:IOrderProductRepository
    {
        private readonly WebContext _context;

        public OrderProductRepository(WebContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderProduct> GetAllOrderProducts()
        {
            return _context.OrderProductses.AsEnumerable();
        }

        public OrderProduct GetOrderProduct(int id)
        {
            return _context.OrderProductses.Find(id);
        }

        public void AddOrderProduct(OrderProduct orderProduct)
        {
            _context.OrderProductses.Add(orderProduct);
            _context.SaveChanges();
        }

        public void UpdateOrderProduct(OrderProduct orderProduct)
        {
            _context.OrderProductses.Update(orderProduct);
            _context.SaveChanges();
        }

        public void DeleteOrderProduct(int id)
        {
            OrderProduct orderProduct = _context.OrderProductses.Find(id);
            if (orderProduct != null)
            {
                _context.OrderProductses.Remove(orderProduct);
                _context.SaveChanges();
            }

        }
    }
}
