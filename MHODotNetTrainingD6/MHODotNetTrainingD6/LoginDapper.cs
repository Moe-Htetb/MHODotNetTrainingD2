using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace MHODotNetTrainingD6
{
    internal class LoginDapper
    {
        private readonly SqlConnectionStringBuilder _connectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "ASUSVivoBook\\MSSQLSERVER2",
            InitialCatalog = "Product",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void read()
        {
            string query = "select * from Tbl_user";
            using IDbConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            var lst = connection.Query<User>(query);


            foreach (var item in lst)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.UserName);
                Console.WriteLine(item.Password);
            }
            Console.ReadLine();
        }

    }
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
