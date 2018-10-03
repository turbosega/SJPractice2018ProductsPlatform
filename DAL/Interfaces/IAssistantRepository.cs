using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAssistantRepository
    {
        Task<IList<Assistant>> GetAll();
        Task<Assistant> GetById(int id);
        Task<int> Create(Assistant assistant);
        Task<int> Update(Assistant assistant);
        Task<int> Delete(int id);
    }
}
