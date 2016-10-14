using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LB_II_1.Classes
{
    class DatabaseInteraction
    {
        
        public static SqlConnection CreateConn(SqlConnection Connection)
        {
            Connection = new SqlConnection(GetConnectionString());
            try
            {
                Connection.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Connection exeption: "+se.Number.ToString());
                if (se.Number == 4060)
                {
                    ExeptionCreateDatabase(Connection);
                    Connection = new SqlConnection(GetConnectionString());
                    Connection.Open();
                }
            }
            finally
            {
                
            }
            return Connection;
        }

        public int GetTable(SqlConnection Connection)
        {
            
            return 0;
        }

        public int SaveTable(SqlConnection Connection)
        {

            return 0;
        }

        public int LostConn(SqlConnection Connection)
        {
            Connection.Close();
            Connection.Dispose();
            return 0;
        }

        private static void ExeptionCreateDatabase(SqlConnection Connection)
        {
            MessageBox.Show("Database creation begin" );
            Connection.Close();
            Connection = new SqlConnection(GetConnectionString()); 
            SqlCommand cmdCreateDatabase = new SqlCommand(GetCreateDatabaseString(), Connection);
            try
            {
                Connection.Open();
                cmdCreateDatabase.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("CreateDatabase exeption: " + se.Number.ToString());
                return;
            }
            Connection.Close();
            Thread.Sleep(5000);
            MessageBox.Show("Database creation end");
        }

        private static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\\MSSQLLocalDB"
                    + "AttachDbFilename=D:\\Projects\\VisualStudio\\LB_II_1\\LB_II_1\\Database\\Database.mdf;"
                    + "Integrated Security=True";
        }

        private static string GetCreateDatabaseString()
        {
            return "CREATE DATABASE [" + Properties.Settings.Default.DBN + "] " +
                   "ON (FILENAME = " + Properties.Settings.Default.DBDir + ") " +
                   "LOG ON (FILENAME = " + Properties.Settings.Default.DBLog + ") " +
                   "FOR ATTACH GO";
        }

        private static string GetCreateSymCostTableString()
        {
            return "CREATE TABLE " + "TableCost " + "("+
                    "Id SMALLINT NOT NULL DEFAULT 0" +
                    ", RheumCount SMALLINT NULL DEFAULT 0" +
                    ", CoughCount SMALLINT NULL DEFAULT 0" +
                    ", ASoreThroatCount SMALLINT NULL DEFAULT 0" +
                    ", FeverTemperatureCount SMALLINT NULL DEFAULT 0" +
                    ", JointPainCount SMALLINT NULL DEFAULT 0" +
                    ", SoreThroatCount SMALLINT NULL DEFAULT 0" +
                    ", SputumCount SMALLINT NULL DEFAULT 0" +
                    ", RattlingInLungsCount SMALLINT NULL DEFAULT 0" +
                    ", vomitingCountCount SMALLINT NULL DEFAULT 0" +
                    ", ASoreThroatPain SMALLINT NULL DEFAULT 0" +
                    ", PainInLungsCount SMALLINT NULL DEFAULT 0" +
                    ", NotSayCount SMALLINT NULL DEFAULT 0"+")";
        }

        public static void CreateTable(SqlConnection Connection)
        {
            SqlCommand cmdCreateTable = new SqlCommand(GetCreateSymCostTableString(), Connection);
            try
            {
                cmdCreateTable.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("CreateTable exeption: " + se.Number.ToString());
                return;
            }
        }

    }
}
