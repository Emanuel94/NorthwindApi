 using Northwind.UnitOfWork;
using NorthWind.Repositories;

namespace NorthWind.DataAccess
{
    public class NorthwindUnitOfWork :  IUnitOfWork
    {

        public NorthwindUnitOfWork(string connectionString)
        {
            Customer = new CustomerRepository(connectionString);
            User = new UserRepository(connectionString);
        }

        public ICustomerRepository Customer { get; private set; }

        public IUserRepository User { get; private set; }
    }
}
