// See https://aka.ms/new-console-template for more information

//using Microsoft.Data.SqlClient;


//SqlConnectionStringBuilder connectioinStringBuilder = new SqlConnectionStringBuilder();
//connectioinStringBuilder.DataSource = "";

//SqlConnection connection = new SqlConnection();

//using MHODotNetTrainingD6;

//HomeworkService homeworkService = new HomeworkService();
//homeworkService.Read();
//homeworkService.ReadDetail(1);
using System.Data;
using MHODotNetTrainingD6;
//using Microsoft.Data.SqlClient;

//SqlConnectionStringBuilder _connectionStringBuilder = new SqlConnectionStringBuilder();
//_connectionStringBuilder.DataSource = "ASUSVivoBook\\MSSQLSERVER2";
//_connectionStringBuilder.InitialCatalog = "Product";
//_connectionStringBuilder.UserID = "sa";
//_connectionStringBuilder.Password = "sasa@123";
//_connectionStringBuilder.TrustServerCertificate = true;

//SqlConnection sqlConnection = new SqlConnection(_connectionStringBuilder.ConnectionString);
//sqlConnection.Open();

//// Fix the table name here
//Console.Write("Enter Product Name:");
//string productName = Console.ReadLine()!;

//Console.Write("Enter Product Price:");
//string productPrice = Console.ReadLine()!;


//string query = $@"INSERT INTO [dbo].[Tbl_products]
//           ([ProductName]
//           ,[ProductPrice])
//     VALUES
//           ('{productName}'
//           ,{productPrice})";
//SqlCommand cmd = new SqlCommand(query, sqlConnection);

////SqlDataAdapter adapter = new SqlDataAdapter(cmd);
////DataTable dataTable = new DataTable();
////adapter.Fill(dataTable);
// int result = cmd.ExecuteNonQuery();

//sqlConnection.Close();

//foreach (DataRow dr in dataTable.Rows)
//{
//    Console.WriteLine(dr["Id"]);
//    Console.WriteLine(dr["ProductName"]);
//    Console.WriteLine(dr["ProductPrice"]);
//    Console.WriteLine("-------------------------");
//}
//Console.ReadLine();

HomeworkService homeworkService = new HomeworkService();
//homeworkService.Read();
//homeworkService.ReadDetail(1);
//homeworkService.Create();
//homeworkService.Update();
//homeworkService.Login();
//homeworkService.LoginWithStroedProcedure();

LoginDapper loginDapper = new LoginDapper();

loginDapper.read();
