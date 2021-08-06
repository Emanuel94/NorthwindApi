using Northwind.Models;
using System.Collections.Generic;

namespace NorthWind.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        IEnumerable<Customer> CustomerPagedList(int Page, int rows);
    }
}
