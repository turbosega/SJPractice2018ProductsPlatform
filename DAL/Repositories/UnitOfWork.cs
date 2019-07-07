using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.DAL.Context;
using WebAPI.DAL.Interfaces;

namespace WebAPI.DAL.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly WebContext _context;
        private CustomerAddressRepository _customerAddressRepository;
        private AddressRepository _addressRepository;
        private CustomerReository _customerReository;
        private CustomerOrderRepository _customerOrderRepository;
        private OrderProductRepository _orderProductRepository;
        private OrderRepository _orderRepository;
        private ProductRepository _productRepository;

        public UnitOfWork(DbContextOptions<WebContext> defaultConnection)
        {
            _context = new WebContext(defaultConnection);
        }


        public ICustomerAddressRepository CustomerAddresses
        {
            get
            {
                if (_customerAddressRepository == null)
                {
                    _customerAddressRepository = new CustomerAddressRepository(_context);
                }

                return _customerAddressRepository;
            }
        }

        public IAddressRepository Addresses
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_context);
                }
                    
                return _addressRepository;
            }
        }

        public ICustomerRepository Customers
        {
            get
            {
                if (_customerReository == null)
                {
                    _customerReository = new CustomerReository(_context);
                }

                return _customerReository;
            }
        }

        public ICustomreOrderRepository CustomreOrders
        {
            get
            {
                if (_customerOrderRepository == null)
                {
                    _customerOrderRepository = new CustomerOrderRepository(_context);
                }

                return _customerOrderRepository;
            }
        }

        public IOrderProductRepository OrderProducts
        {
            get
            {
                if (_orderProductRepository == null)
                {
                    _orderProductRepository = new OrderProductRepository(_context);
                }

                return _orderProductRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_context);
                }

                return _orderRepository;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_context);
                }

                return _productRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
