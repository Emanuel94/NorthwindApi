using NorthWind.Repositories;
 
namespace Northwind.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICustomerRepository Customer { get; }
        public IUserRepository User { get; }
    }
}
