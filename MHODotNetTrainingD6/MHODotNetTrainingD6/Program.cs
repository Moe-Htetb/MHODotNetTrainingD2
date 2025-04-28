// See https://aka.ms/new-console-template for more information

//using Microsoft.Data.SqlClient;


//SqlConnectionStringBuilder connectioinStringBuilder = new SqlConnectionStringBuilder();
//connectioinStringBuilder.DataSource = "";

//SqlConnection connection = new SqlConnection();

using MHODotNetTrainingD6;

HomeworkService homeworkService = new HomeworkService();
homeworkService.Read();
homeworkService.ReadDetail(1);