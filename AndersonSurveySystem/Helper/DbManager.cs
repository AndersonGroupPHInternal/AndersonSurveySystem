using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AndersonSurveySystem.Helper
{
    public class DbManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["AndersonSurveySystemConnectionString"].ConnectionString; // connection

        //For data manipulation (retrieve data)
        public DataTable SqlReader(string query, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Create a new DataTable.
                    DataTable dt = new DataTable(tableName);

                    //Load DataReader into the DataTable.
                    dt.Load(reader);

                    connection.Dispose();
                    connection.Close();
                    return dt;
                }
            }
        }

        //For data manipulation (retrieve data)
        public DataTable SqlReader(string query, string tableName, List<Admin> admins)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                foreach (var admin in admins)
                {
                    command.Parameters.AddWithValue(admin.UserName, admin.Password);
                }
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    //Create a new DataTable.
                    DataTable dt = new DataTable(tableName);

                    //Load DataReader into the DataTable.
                    dt.Load(reader);

                    connection.Dispose();
                    connection.Close();
                    return dt;
                }
            }
        }
        //For query with parameter data to database
        public Boolean SqlNonQuery(string query, List<Admin> admins)
        {
            Boolean success;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var admin in admins)
                    {
                        command.Parameters.AddWithValue(admin.UserName, admin.Password);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Dispose();
                    connection.Close();
                    success = true;
                }
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        //Return singgle value
        public string SqlReader(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                string value = command.ExecuteScalar().ToString();
                connection.Dispose();
                connection.Close();
                return value;
            }
        }
    }
}
