using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MHODotNetTrainingD6
{
    internal class HomeworkService
    {
        private readonly SqlConnectionStringBuilder _connectionStringBuilder = new SqlConnectionStringBuilder()
          {
            DataSource = ".",
            InitialCatalog = "DotNetTrainingBatch1",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from table");
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();
            foreach (DataRow dr in dataTable.Rows)
            {
                Console.WriteLine(dr["No"]);
                Console.WriteLine(dr["Name"]);
                Console.WriteLine(dr["GitHubUserName"]);
                Console.WriteLine("-------------------------");
            }
        }

        public void ReadDetail(int no)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"select * from table where no = ${no}");
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            sqlConnection.Close();

            if(dataTable.Rows.Count == 0)
            {
                Console.WriteLine("No Record Found");
            }

            DataRow dr = dataTable.Rows[0];

                Console.WriteLine(dr["No"]);
                Console.WriteLine(dr["Name"]);
                Console.WriteLine(dr["GitHubUserName"]);
                Console.WriteLine("-------------------------");
            
        }

    }
}
