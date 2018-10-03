using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StoreContext _context;

        public CustomerRepository(StoreContext context)
        {
            _context = context;
        }
        public Task<int> Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}