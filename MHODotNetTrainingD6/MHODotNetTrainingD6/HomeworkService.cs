using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MHODotNetTrainingD6
{
    internal class HomeworkService
    {
        private readonly SqlConnectionStringBuilder _connectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "ASUSVivoBook\\MSSQLSERVER2",
            InitialCatalog = "Product",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionStringBuilder.ConnectionString);

            sqlConnection.Open();

            string query = "select * from Tbl_products";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            sqlConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["Id"]);
                Console.WriteLine(dr["ProductName"]);
                Console.WriteLine(dr["ProductPrice"]);
                Console.WriteLine("-------------------------");
            }
        }

        public void ReadDetail(int no)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionStringBuilder.ConnectionString);

            sqlConnection.Open();

            string query = $"select * from Tbl_products where Id = ${no}";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            sqlConnection.Close();

            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("No Record Found");
            }

            DataRow dr = dt.Rows[0];

            Console.WriteLine(dr["Id"]);
            Console.WriteLine(dr["ProductName"]);
            Console.WriteLine(dr["ProductPrice"]);
            Console.WriteLine("-------------------------");

        }


        public void Create()
        {
            Console.Write("Enter ProductName: ");
            string productName = Console.ReadLine()!;

            Console.Write("Enter ProductPrice: ");
            string productPrice = Console.ReadLine()!;

            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();


            string query = $@"INSERT INTO [dbo].[Tbl_products]
           ([ProductName]
           ,[ProductPrice])
              VALUES
           ('{productName}'
           ,{productPrice})";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ProducttName", productName);
            cmd.Parameters.AddWithValue("@ProductPrice", productPrice);

            int result = cmd.ExecuteNonQuery();


            connection.Close();
        }



        public void Update()
        {
        beforeId:
            Console.Write("Enter Id: ");
            string id = Console.ReadLine()!;
       

            int realId = 0;

            bool isInteger = int.TryParse(id, out realId);
            if (!isInteger)
            {
                Console.WriteLine("Invalid Format");
                goto beforeId;
            }

            //check  realID is exit in database


            Console.Write("Enter ProductName: ");
            string productName = Console.ReadLine()!;


        beforePrice:
            Console.Write("Enter ProductPrice: ");
            string productPrice = Console.ReadLine()!;

            int realProductPrice = 0;

            bool isInt = int.TryParse(productPrice, out realProductPrice);

            if (!isInt) {
                Console.WriteLine(" Invalid Format");
                goto beforePrice;
            }

            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();

      

            string query = $@"
            UPDATE [dbo].[Tbl_products]
              SET [ProductName]= @ProductName  
                 ,[ProductPrice]=@ProductPrice
             WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
            cmd.Parameters.AddWithValue("@Id", realId);


            int result = cmd.ExecuteNonQuery();




            connection.Close();
        }      
    
        
        public void Login()
        {
      


            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine()!;

            Console.Write("Enter Paaword: ");
            string password = Console.ReadLine()!;


            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();

      

            string query = $"select * from Tbl_User where UserName=@userName and Password = @Password";
            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Password", password);
     
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }

            connection.Close();
        }


        public void LoginWithStroedProcedure()
        {



            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine()!;

            Console.Write("Enter Paaword: ");
            string password = Console.ReadLine()!;


            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();



            string query = $"Sp_login";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@Password", password);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }

            connection.Close();
        }
    }
}
