namespace WebAPI.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerAddressRepository CustomerAddresses { get; }
        IAddressRepository Addresses { get; }
        ICustomerRepository Customers { get; }
        ICustomreOrderRepository CustomreOrders { get; }
        IOrderProductRepository OrderProducts { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }

        void Save();
    }
}
