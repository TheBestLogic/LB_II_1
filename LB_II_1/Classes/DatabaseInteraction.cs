using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LB_II_1.Classes.SimptomeWrite;

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
                MessageBox.Show("Connection exeption: "+se.Number.ToString()+"\n"+se.Message);
                if (se.Number == 4060)
                {
                    ExeptionCreateDatabase(Connection);
                    Connection = new SqlConnection(GetConnectionString());
                }
            }
            Connection.Close();
            return Connection;
        }

        public static int LostConn(SqlConnection Connection)
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
                MessageBox.Show("CreateDatabase exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
                return;
            }
            NewTables(Connection);
            Connection.Close();
            Thread.Sleep(5000);
            MessageBox.Show("Database creation end");
        }

        private static string GetConnectionString()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;"
                    + "AttachDbFilename="+ Properties.Settings.Default.DBDir + ";"
                    + " Integrated Security=True";
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
                Connection.Open();
                cmdCreateTable.ExecuteNonQuery();
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("CreateTable exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
                return;
            }
        }

        public static void NewTables(SqlConnection Connection)
        {
            string Ex = null;
            string Table1 = string.Format("INSERT INTO TableCost(Id, RheumCount, CoughCount, " +
                "ASoreThroatCount, FeverTemperatureCount, JointPainCount, SoreThroatCount, SputumCount" +
                ", RattlingInLungsCount, PainInLungsCount, NotSayCount) values(" +
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10});", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            string Table2 = string.Format("INSERT INTO TableCost(Id, RheumCount, CoughCount, " +
                "ASoreThroatCount, FeverTemperatureCount, JointPainCount, SoreThroatCount, SputumCount" +
                ", RattlingInLungsCount, PainInLungsCount, NotSayCount) values(" +
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})", 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            string Table3 = string.Format("INSERT INTO TableCost(Id, RheumCount, CoughCount, " +
                "ASoreThroatCount, FeverTemperatureCount, JointPainCount, SoreThroatCount, SputumCount" +
                ", RattlingInLungsCount, PainInLungsCount, NotSayCount) values(" +
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            string Table4 = string.Format("INSERT INTO TableCost(Id, RheumCount, CoughCount, " +
                "ASoreThroatCount, FeverTemperatureCount, JointPainCount, SoreThroatCount, SputumCount" +
                ", RattlingInLungsCount, PainInLungsCount, NotSayCount) values(" +
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})", 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            string Table5 = string.Format("INSERT INTO TableCost(Id, RheumCount, CoughCount, " +
                "ASoreThroatCount, FeverTemperatureCount, JointPainCount, SoreThroatCount, SputumCount" +
                ", RattlingInLungsCount, PainInLungsCount, NotSayCount) values(" +
                "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})", 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            SqlCommand cmdCreateTable1 = new SqlCommand(Table1, Connection);
            SqlCommand cmdCreateTable2 = new SqlCommand(Table2, Connection);
            SqlCommand cmdCreateTable3 = new SqlCommand(Table3, Connection);
            SqlCommand cmdCreateTable4 = new SqlCommand(Table4, Connection);
            SqlCommand cmdCreateTable5 = new SqlCommand(Table5, Connection);
            try
            {
                Connection.Open();
                Ex += "->cmdCreateTable1";
                cmdCreateTable1.ExecuteNonQuery();
                Ex += "->\ncmdCreateTable2";
                cmdCreateTable2.ExecuteNonQuery();
                Ex += "->\ncmdCreateTable3";
                cmdCreateTable3.ExecuteNonQuery();
                Ex += "->\ncmdCreateTable4";
                cmdCreateTable4.ExecuteNonQuery();
                Ex += "->\ncmdCreateTable5";
                cmdCreateTable5.ExecuteNonQuery();
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("INSERT exeption: " + se.Number.ToString() + "\n" + se.Message + "\n\n\n" + Ex);
                Connection.Close();
            }
        }

        public static SYMPTOME_COST[] GetTables(SqlConnection Connection, SYMPTOME_COST[] SymC)
        {
            string sqlExpression = "SELECT * FROM TableCost";
            int i = 0;
            SqlCommand command = new SqlCommand(sqlExpression, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        SymC[i].ID = reader.GetInt16(0);//[Id]
                        SymC[i].Rheum = reader.GetInt16(1);//[RheumCount]  
                        SymC[i].Cough = reader.GetInt16(2);//[CoughCount]
                        SymC[i].ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                        SymC[i].FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                        SymC[i].JointPain = reader.GetInt16(5);//[JointPainCount]
                        SymC[i].SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                        SymC[i].Sputum = reader.GetInt16(7);//[SputumCount]
                        SymC[i].RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                        SymC[i].PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                        SymC[i].NotSay = reader.GetInt16(10);//[NotSayCount]
                        ++i;
                    }
                Connection.Close();
            }
            catch(SqlException se)
            {
                MessageBox.Show("GetTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }

            return SymC;
            
        }

        public static SYMPTOME_COST GetSoloTable(SqlConnection Connection, SYMPTOME_COST SymC, int DeseareIndex)
        {
            SymC.Clear();
            string sqlExpression = "SELECT * FROM TableCost WHERE Id =" + DeseareIndex + ';';
            SqlCommand command = new SqlCommand(sqlExpression, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                switch (DeseareIndex)
                {
                    case 1://Pneumonia
                        if (reader.Read())
                        {
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                            SymC.PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                        }
                        break;
                    case 2://Angina
                        if (reader.Read())
                        {
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.JointPain = reader.GetInt16(5);//[JointPainCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                        }
                        break;
                    case 3://Flu
                        if (reader.Read())
                        { 
                            SymC.Rheum = reader.GetInt16(1);//[RheumCount]  
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                        }
                        break;
                    case 4://Pharyngitis
                        if (reader.Read())
                        { 
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                            SymC.NotSay = reader.GetInt16(10);//[NotSayCount]
                        }
                        break;
                    case 5://Bronchitis
                        if (reader.Read())
                        {
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.Sputum = reader.GetInt16(7);//[SputumCount]
                            SymC.RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                            SymC.PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                        }
                        break;
                    default:
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.Rheum = reader.GetInt16(1);//[RheumCount]  
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.JointPain = reader.GetInt16(5);//[JointPainCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                            SymC.Sputum = reader.GetInt16(7);//[SputumCount]
                            SymC.RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                            SymC.PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                            SymC.NotSay = reader.GetInt16(10);//[NotSayCount]
                        }
                        break;
                }
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("GetSoloTable "+ DeseareIndex + " - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }
            return SymC;
        }

        public static void UpdateTable(SqlConnection Connection, SYMPTOME_COST SymC = default(SYMPTOME_COST), int flag = 0, SYMPTOME_COST[] SymCM = default(SYMPTOME_COST[]))
        {
            string sqlExpression = null, Ex = null;
            SqlCommand command2 = null;
            SqlCommand command3 = null;
            SqlCommand command4 = null;
            SqlCommand command5 = null;
            switch (flag)
            {
                case 1://Pneumonia
                    sqlExpression = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", RattlingInLungsCount=" + SymC.RattlingInLungs +
                    ", PainInLungsCount=" + SymC.PainInLungs +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
                case 2://Angina
                    sqlExpression = "UPDATE TableCost SET " +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", JointPainCount=" + SymC.JointPain +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
                case 3://Flu
                    sqlExpression = "UPDATE TableCost SET " +
                    "RheumCount=" + SymC.Rheum +
                    ", CoughCount=" + SymC.Cough +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
                case 4://Pharyngitis
                    sqlExpression = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    ", NotSayCount=" + SymC.NotSay +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
                case 5://Bronchitis
                    sqlExpression = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", SputumCount=" + SymC.Sputum +
                    ", RattlingInLungsCount=" + SymC.RattlingInLungs +
                    ", PainInLungsCount=" + SymC.PainInLungs +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
                case 6:
                    sqlExpression = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", RattlingInLungsCount=" + SymC.RattlingInLungs +
                    ", PainInLungsCount=" + SymC.PainInLungs +
                    "WHERE Id =" + SymC.ID + ';';
                    string sqlExpression2 = "UPDATE TableCost SET " +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", JointPainCount=" + SymC.JointPain +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    "WHERE Id =" + SymC.ID + ';';
                    string sqlExpression3 = "UPDATE TableCost SET " +
                    "RheumCount=" + SymC.Rheum +
                    ", CoughCount=" + SymC.Cough +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    "WHERE Id =" + SymC.ID + ';';
                    string sqlExpression4 = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    ", NotSayCount=" + SymC.NotSay +
                    "WHERE Id =" + SymC.ID + ';';
                    string sqlExpression5 = "UPDATE TableCost SET " +
                    ", CoughCount=" + SymC.Cough +
                    ", SputumCount=" + SymC.Sputum +
                    ", RattlingInLungsCount=" + SymC.RattlingInLungs +
                    ", PainInLungsCount=" + SymC.PainInLungs +
                    "WHERE Id =" + SymC.ID + ';';
                    command2 = new SqlCommand(sqlExpression2, Connection);
                    command3 = new SqlCommand(sqlExpression3, Connection);
                    command4 = new SqlCommand(sqlExpression4, Connection);
                    command5 = new SqlCommand(sqlExpression5, Connection);
                    break;
                default:
                    sqlExpression = "UPDATE TableCost SET " +
                    "RheumCount=" + SymC.Rheum +
                    ", CoughCount=" + SymC.Cough +
                    ", ASoreThroatCount=" + SymC.ASoreThroatPain +
                    ", FeverTemperatureCount=" + SymC.FeverTemperature +
                    ", JointPainCount=" + SymC.JointPain +
                    ", SoreThroatCount=" + SymC.SoreThroat +
                    ", SputumCount=" + SymC.Sputum +
                    ", RattlingInLungsCount=" + SymC.RattlingInLungs +
                    ", PainInLungsCount=" + SymC.PainInLungs +
                    ", NotSayCount=" + SymC.NotSay +
                    "WHERE Id =" + SymC.ID + ';';
                    break;
            }
                    SqlCommand command = new SqlCommand(sqlExpression, Connection);
                    try
                    {
                        Connection.Open();
                        Ex += "->\nUpdateTable1";
                        command.ExecuteNonQuery();
                        if (flag == 6)
                        {
                            Ex += "->\nUpdateTable2";
                            command2.ExecuteNonQuery();
                            Ex += "->\nUpdateTable3";
                            command3.ExecuteNonQuery();
                            Ex += "->\nUpdateTable4";
                            command4.ExecuteNonQuery();
                            Ex += "->\nUpdateTable5";
                            command5.ExecuteNonQuery();
                        }
                        Connection.Close();
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("UpdateTable("+ flag+") - " + "Update exeption: " + se.Number.ToString() + "\n" + se.Message);
                        Connection.Close();
                    }
            }

        public static int NeedNewTables(SqlConnection Connection)
    {
        int control_index = 0;
        bool first = true, second = true, third = true, fourth = true, fifth = true;
        string sqlExpression = "SELECT * FROM TableCost";
        SqlCommand command = new SqlCommand(sqlExpression, Connection);
        try
        {
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            {
                while (reader.Read())
                {
                    ++control_index;
                    if (control_index == 1)
                    {
                        first = (reader.GetInt16(0) == 1) ? (true) : (false);
                    }
                    if (control_index == 2)
                    {
                        second = (reader.GetInt16(0) == 2) ? (true) : (false);
                    }
                    if (control_index == 3)
                    {
                        third = (reader.GetInt16(0) == 3) ? (true) : (false);
                    }
                    if (control_index == 4)
                    {
                        fourth = (reader.GetInt16(0) == 4) ? (true) : (false);
                    }
                    if (control_index == 5)
                    {
                        fifth = (reader.GetInt16(0) == 5) ? (true) : (false);
                    }

                }
                Connection.Close();
                if (!first || !second || !third || !fourth || !fifth || control_index != 5)
                {
                    DropTable(Connection);
                    CreateTable(Connection);
                    NewTables(Connection);
                }
            }

        }
        catch (SqlException se)
        {
            MessageBox.Show("NeedNewTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
            Connection.Close();
        }
        return 0;
    }

        public static void DropTable(SqlConnection Connection)
        {
            string sqlExpression = "DROP TABLE TableCost";
            SqlCommand command = new SqlCommand(sqlExpression, Connection);
            SqlCommand cmdDropTable = new SqlCommand(sqlExpression, Connection);
            try
            {
                Connection.Open();
                cmdDropTable.ExecuteNonQuery();
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("DropTable - " + "DROP exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }
        }


    }
}