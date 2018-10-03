using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IList<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<int> Create(Customer customer);
        Task<int> Update(Customer customer);
        Task<int> Delete(int id);
    }
}
