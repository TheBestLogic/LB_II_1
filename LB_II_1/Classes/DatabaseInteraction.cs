using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Timers;
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
                else
                {
                    Connection.Close();
                    return null;
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

        public static SYMPTOME_COST GetSoloOrAllTables(SqlConnection Connection, int flag = 0, SYMPTOME_COST SymC = default(SYMPTOME_COST), SYMPTOME_COST[] SymCM = default(SYMPTOME_COST[]))
        {
            string sqlExpression = "SELECT * FROM TableCost", Ex= "\n\nGetSoloOrAllTables(flag== "+flag+" ):\n";
            if (flag > 0 && flag < 6)
            {
                sqlExpression +=" WHERE Id = " + flag + ';';
            }
            SqlCommand command = new SqlCommand(sqlExpression, Connection);
            try
            {
                Ex += "\tConnection.Open()\n";
                Connection.Open();
                Ex += "\tcommand.ExecuteReader()\n";
                SqlDataReader reader = command.ExecuteReader();
                Ex += "\tswitch (flag)\n";
                switch (flag)
                {
                    case 1://Pneumonia
                        Ex += "\t\tcase 1\n";
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                            SymC.PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    case 2://Angina
                        Ex += "\t\tcase 2\n";
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.JointPain = reader.GetInt16(5);//[JointPainCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    case 3://Flu
                        Ex += "\t\tcase 3\n";
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.Rheum = reader.GetInt16(1);//[RheumCount]  
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    case 4://Pharyngitis
                        Ex += "\t\tcase 4\n";
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                            SymC.FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                            SymC.SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                            SymC.NotSay = reader.GetInt16(10);//[NotSayCount]
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    case 5://Bronchitis
                        Ex += "\t\tcase 5\n";
                        if (reader.Read())
                        {
                            SymC.ID = reader.GetInt16(0);//[Id]
                            SymC.Cough = reader.GetInt16(2);//[CoughCount]
                            SymC.Sputum = reader.GetInt16(7);//[SputumCount]
                            SymC.RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                            SymC.PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    case 6:
                        int i = 0;
                        Ex += "\t\tcase 6\n";
                        if (reader.HasRows)
                        {
                            Ex += "\t\t\treader.Read()\n";
                            while (reader.Read())
                            {
                                SymCM[i].ID = reader.GetInt16(0);//[Id]
                                SymCM[i].Rheum = reader.GetInt16(1);//[RheumCount]  
                                SymCM[i].Cough = reader.GetInt16(2);//[CoughCount]
                                SymCM[i].ASoreThroatPain = reader.GetInt16(3);//[ASoreThroatCount]
                                SymCM[i].FeverTemperature = reader.GetInt16(4);//[FeverTemperatureCount]
                                SymCM[i].JointPain = reader.GetInt16(5);//[JointPainCount]
                                SymCM[i].SoreThroat = reader.GetInt16(6);//[SoreThroatCount]
                                SymCM[i].Sputum = reader.GetInt16(7);//[SputumCount]
                                SymCM[i].RattlingInLungs = reader.GetInt16(8);//[RattlingInLungsCount]
                                SymCM[i].PainInLungs = reader.GetInt16(9);//[PainInLungsCount]
                                SymCM[i].NotSay = reader.GetInt16(10);//[NotSayCount]
                                ++i;
                                Ex += "\t\t\t\twhile(reader.Read(), i== "+i+" )\n";
                            }
                            Connection.Close();
                            return SymCM[0];
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                    default:
                        Ex += "\t\tdefault\n";
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
                            Ex += "\t\t\treader.Read()\n";
                        }
                        else
                        {
                            Ex += "\t\t\t!reader.Read()\n";
                        }
                        break;
                }
                    
                Connection.Close();
            }
            catch(SqlException se)
            {
                MessageBox.Show("GetSoloOrAllTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message + Ex);
                Connection.Close();
            }
            return SymC;
        }

        public static void UpdateTable(SqlConnection Connection, int flag = 0, SYMPTOME_COST SymC = default(SYMPTOME_COST), SYMPTOME_COST[] SymCM = default(SYMPTOME_COST[]))
        {
            string sqlExpression = null, Ex = "\n\nUpdateTable(flag == "+flag+" ):\n";
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
                        Ex += "\tConnection.Open()\n";
                        Connection.Open();
                        Ex += "\tcommand.ExecuteNonQuery()\n";
                        command.ExecuteNonQuery();
                        if (flag == 6)
                        {
                            Ex += "\t\tcommand2.ExecuteNonQuery()\n";
                            command2.ExecuteNonQuery();
                            Ex += "-\t\tcommand3.ExecuteNonQuery()\n";
                            command3.ExecuteNonQuery();
                            Ex += "\t\tcommand4.ExecuteNonQuery()\n";
                            command4.ExecuteNonQuery();
                            Ex += "\t\tcommand5.ExecuteNonQuery()\n";
                            command5.ExecuteNonQuery();
                        }
                        Connection.Close();
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("UpdateTable("+ flag+") - " + "Update exeption: " + se.Number.ToString() + "\n" + se.Message+Ex);
                        Connection.Close();
                    }
            }

        public static int NeedNewTables(SqlConnection Connection)
    {
        int control_index = 0;
        short check;
        bool first = false, second = false, third = false, fourth = false, fifth = false;
        string sqlExpression = "SELECT * FROM TableCost";
        SqlCommand command = new SqlCommand(sqlExpression, Connection);
        try
        {
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            ++control_index;
                            check = reader.GetInt16(0);
                            if (check == 1)
                            {
                                first = true;
                            }
                            if (check == 2)
                            {
                                second = true;
                            }
                            if (check == 3)
                            {
                                third = true;
                            }
                            if (check == 4)
                            {
                                fourth = true;
                            }
                            if (check == 5)
                            {
                                fifth = true;
                            }
                        }
                }
                Connection.Close();
                if (!first || !second || !third || !fourth || !fifth || control_index != 5)
                {
                        TrancateTable(Connection);
                    CreateTable(Connection);
                    NewTables(Connection);
                }
            }

        }
        catch (SqlException se)
        {
            MessageBox.Show("NeedNewTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
                
                Connection.Close();
                CreateTable(Connection);
        }
        return 0;
    }

        public static void TrancateTable(SqlConnection Connection)
        {
            string sqlExpression = "TRUNCATE TABLE TableCost";
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
                MessageBox.Show("TrancateTable - " + "TRUNCATE exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }
        }

        
    }
}