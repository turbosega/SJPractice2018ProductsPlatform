using System.Collections.Generic;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Interfaces
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAllAddresses();
        Address GetAddress(int id);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(int id);
    }
}
