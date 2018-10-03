using DAL.Entities;
using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAssistantRepository Assistants { get; }
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
       
        void StartTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
