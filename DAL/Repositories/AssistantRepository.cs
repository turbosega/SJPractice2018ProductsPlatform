using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class AssistantRepository : IAssistantRepository
    {
        private readonly StoreContext _context;

        public AssistantRepository(StoreContext context)
        {
            _context = context;
        }

        public Task<int> Create(Assistant assistant)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Assistant>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Assistant> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Assistant assistant)
        {
            throw new NotImplementedException();
        }
    }
}