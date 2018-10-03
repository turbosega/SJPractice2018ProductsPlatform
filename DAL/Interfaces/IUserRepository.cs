using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        Task<IList<User>> GetAll();
        Task<User> GetById(int id);
        Task<int> Create(User user);
        Task<int> Update(User user);
        Task<int> Delete(int id);
    }
}
