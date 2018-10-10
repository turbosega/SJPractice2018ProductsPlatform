using System.Collections.Generic;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Interfaces
{
    public interface ICustomerAddressRepository
    {
        IEnumerable<CustomerAddress> GetAllCustomerAddresses();
        CustomerAddress GetCustomerAddress(int id);
        void AddCustomerAddress(CustomerAddress customerAddress);
        void UpdateCustomerAddress(CustomerAddress customerAddress );
        void DeleteCustomerAddress(int id);
    }
}
