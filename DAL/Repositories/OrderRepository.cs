using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http.Features;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly WebContext _context;

        public OrderRepository(WebContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.AsEnumerable();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.Find(id);
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
