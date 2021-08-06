using Northwind.Models;
 

namespace NorthWind.Repositories
{
   public interface IUserRepository :IRepository<User>
    {
        User ValidateUser(string email, string password);
    }
}
