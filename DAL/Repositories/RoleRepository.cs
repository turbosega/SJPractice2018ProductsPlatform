using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly StoreContext _context;

        public RoleRepository(StoreContext context)
        {
            _context = context;
        }
        public Task<int> Create(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Role>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}