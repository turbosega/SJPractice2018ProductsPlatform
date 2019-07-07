using System.Collections.Generic;
using System.Linq;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class CustomerOrderRepository:ICustomreOrderRepository
    {
        private readonly WebContext _context;

        public CustomerOrderRepository(WebContext context)
        {
            _context = context;
        }

        public IEnumerable<CustomerOrder> GetAllCustomerOrders()
        {
            return _context.CustomerOrderses.AsEnumerable();
        }

        public CustomerOrder GetCustomerOrder(int id)
        {
            return _context.CustomerOrderses.Find(id);
        }

        public void AddCustomerOrder(CustomerOrder customerOrder)
        {
            _context.CustomerOrderses.Add(customerOrder);
            _context.SaveChanges();
        }

        public void UpdateCustomerOrder(CustomerOrder customerOrder)
        {
            _context.CustomerOrderses.Update(customerOrder);
            _context.SaveChanges();
        }

        public void DeleteCustomerOrder(int id)
        {
            CustomerOrder customerOrder = _context.CustomerOrderses.Find(id);
            if (customerOrder != null)
            {
                _context.CustomerOrderses.Remove(customerOrder);
                _context.SaveChanges();
            }
        }
    }
}
