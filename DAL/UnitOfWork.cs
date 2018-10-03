using System;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;
        private IDbContextTransaction _transaction;

        private AssistantRepository _assistantRepository;
        private CustomerRepository _custoremRepository;
        private OrderRepository _orderRepository;
        private ProductRepository _productRepository;
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;

        public UnitOfWork(StoreContext context)
        {
            _context = context;
        }

        public IAssistantRepository Assistants
        {
            get { return _assistantRepository ?? (_assistantRepository = new AssistantRepository(_context)); }
        }

        public ICustomerRepository Customers
        {
            get { return _custoremRepository ?? (_custoremRepository = new CustomerRepository(_context)); }
        }

        public IOrderRepository Orders
        {
            get { return _orderRepository ?? (_orderRepository = new OrderRepository(_context)); }
        }

        public IProductRepository Products
        {
            get { return _productRepository ?? (_productRepository = new ProductRepository(_context)); }
        }

        public IRoleRepository Roles
        {
            get { return _roleRepository ?? (_roleRepository = new RoleRepository(_context)); }
        }

        public IUserRepository Users
        {
            get { return _userRepository ?? (_userRepository = new UserRepository(_context)); }
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void StartTransaction()
        {
            if (_transaction == null)
            {
                _transaction = _context.Database.BeginTransaction();
            }
        }
    }

}