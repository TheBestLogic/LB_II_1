using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LB_II_1.Classes
{
    class DatabaseInteraction
    {
        
        public int CreateConn()
        {
            SqlConnection myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            // SqlCommand myCommand = new SqlCommand("Command String", myConnection);

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

            return 0;
        }

        static private string GetConnectionString()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\VisualStudio\\LB_II_1\\LB_II_1\\Database\\Database.mdf;Integrated Security=True";
        }
    }
}
