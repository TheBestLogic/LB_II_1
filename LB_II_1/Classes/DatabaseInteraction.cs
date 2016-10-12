using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace LB_II_1.Classes
{
    class DatabaseInteraction
    {

        public SqlConnection Connection;


        public int CreateConn()
        {
            Connection = new SqlConnection(GetConnectionString());
            try
            {
                Connection.Open();
            }
            catch (SqlException se)
            {
                if (se.Number == 4060)
                {
                    ExeptionCreateDatabase();
                    Connection = new SqlConnection(GetConnectionString());
                    Connection.Open();
                }
            }
            finally
            {
                
            }
            return 0;
        }

        public int GetTable()
        {
            
            return 0;
        }

        public int SaveTable()
        {

            return 0;
        }

        public int LostConn()
        {
            Connection.Close();
            Connection.Dispose();
            return 0;
        }

        private void ExeptionCreateDatabase()
        {
            Connection.Close();
            Connection = new SqlConnection(GetConnectionString());
            SqlCommand cmdCreateDataBase = new SqlCommand(string.Format("CREATE DATABASE [{0}]", "Database"), Connection);
            Connection.Open();
            cmdCreateDataBase.ExecuteNonQuery();
            Connection.Close();
            Thread.Sleep(5000);
        }
        
        private string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\\MSSQLLocalDB"
                    + "AttachDbFilename=D:\\Projects\\VisualStudio\\LB_II_1\\LB_II_1\\Database\\Database.mdf;"
                    + "Integrated Security=True";
        }

        private string GetCreateDatabaseString()
        {
            return "";
        }

        private string GetCreateSymTableString()
        {
            return "";
        }

        private string GetCreateSymCostTableString()
        {
            return "";
        }

    }
}
