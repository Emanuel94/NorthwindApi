using Dapper;
using Northwind.Models;
using NorthWind.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace NorthWind.DataAccess
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<Customer> CustomerPagedList(int Page, int rows)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@page", Page);
            parameter.Add("@rows", rows);
            using (var connection = new SqlConnection(_connectionString)) 
            {
              return connection.Query<Customer>("dbo.CustomerPagedList",
                  parameter,
                  commandType: System.Data.CommandType.StoredProcedure);
            }

        }
    }
}
