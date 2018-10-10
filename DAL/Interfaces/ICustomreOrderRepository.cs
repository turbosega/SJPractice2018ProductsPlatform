using System.Collections.Generic;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Interfaces
{
    public interface ICustomreOrderRepository
    {
        IEnumerable<CustomerOrder> GetAllCustomerOrders();
        CustomerOrder GetCustomerOrder(int id);
        void AddCustomerOrder(CustomerOrder customerOrder);
        void UpdateCustomerOrder(CustomerOrder customerOrder);
        void DeleteCustomerOrder(int id);
    }
}
