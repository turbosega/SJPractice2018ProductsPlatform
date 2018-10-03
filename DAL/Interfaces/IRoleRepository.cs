using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRoleRepository
    {
        Task<IList<Role>> GetAll();
        Task<Role> GetById(int id);
        Task<int> Create(Role role);
        Task<int> Update(Role role);
        Task<int> Delete(int id);
    }
}
