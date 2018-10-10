using System.Collections.Generic;
using System.Linq;
using WebAPI.DAL.Context;
using WebAPI.DAL.Entities;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class AddressRepository:IAddressRepository
    {

        private readonly WebContext _context;

        public AddressRepository(WebContext context)
        {
            _context = context;
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return _context.Addresses.AsEnumerable();
        }

        public Address GetAddress(int id)
        {
            return _context.Addresses.Find(id);
        }

        public void AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void UpdateAddress(Address address)
        {
            _context.Addresses.Update(address);
            _context.SaveChanges();
        }

        public void DeleteAddress(int id)
        {
            Address address = _context.Addresses.Find(id);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }
    }
}
