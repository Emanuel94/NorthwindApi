using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using NorthWind.Repositories;


namespace NorthWind.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;
        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
            _connectionString = connectionString;
        }
        public bool Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString)) {
                return connection.Delete(entity);
            }
         }

        public T GetById(int Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(Id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}
