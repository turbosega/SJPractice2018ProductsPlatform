using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class CustomerReository : ICustomerRepository
    {
        private readonly WebContext _context;

        public CustomerReository(WebContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.AsEnumerable();
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customers.Find(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
