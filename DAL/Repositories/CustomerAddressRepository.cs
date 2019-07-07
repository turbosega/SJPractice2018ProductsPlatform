using System.Collections.Generic;
using System.Linq;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class CustomerAddressRepository:ICustomerAddressRepository
    {
        private readonly WebContext _context;

        public CustomerAddressRepository(WebContext context)
        {
            _context = context;
        }

        public IEnumerable<CustomerAddress> GetAllCustomerAddresses()
        {
            return _context.CustomerAddresseses.AsEnumerable();
        }

        public CustomerAddress GetCustomerAddress(int id)
        {
            return _context.CustomerAddresseses.Find(id);
        }

        public void AddCustomerAddress(CustomerAddress customerAddress)
        {
            _context.CustomerAddresseses.Add(customerAddress);
            _context.SaveChanges();
        }

        public void UpdateCustomerAddress(CustomerAddress customerAddress)
        {
            _context.CustomerAddresseses.Update(customerAddress);
            _context.SaveChanges();
        }

        public void DeleteCustomerAddress(int id)
        {
            CustomerAddress customerAddress = _context.CustomerAddresseses.Find(id);
            if (customerAddress != null)
            {
                _context.CustomerAddresseses.Remove(customerAddress);
                _context.SaveChanges();
            }
        }
    }
}
