using System;
using System.Data;
using System.Data.SqlClient;

namespace Client
{
    internal class SqlData
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Numbers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //reed from data base
        public void GetData(ref DataSet dataSet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //open connection
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Numbers", "Numbers");
                //create Select command text
                string sqlExpression = "SELECT Numbers FROM [dbo].[Table]";
                //create Select command
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.Text;
                //set Select command.
                adapter.SelectCommand = command;
                //et data to table
                adapter.Fill(dataSet);
                //close connection
                connection.Close();
            }
        }

        //write to data base
        public void WriteData(int num)
        {
            //create command text
            string sqlExpression = String.Format("INSERT INTO [dbo].[Table] (Numbers) VALUES ({0})", num);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //open connection
                connection.Open();
                //create Insert command
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                //insert number
                command.ExecuteNonQuery();
                //close connection
                connection.Close();
            }
        }
        //write to data base
        public void DeleteData()
        {
            //create command text
            string sqlExpression1 = "DELETE FROM [dbo].[Table];";
            string sqlExpression2 = "DBCC CHECKIDENT('[dbo].[Table]', RESEED, 0);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //open connection
                connection.Open();
                //create delete command
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                //delete numbers
                command.ExecuteNonQuery();
                //reset identity 
                command = new SqlCommand(sqlExpression2, connection);
                command.ExecuteNonQuery();
                //close connection
                connection.Close();
            }
        }
    }
}