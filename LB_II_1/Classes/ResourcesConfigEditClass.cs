using System.IO;
using static LB_II_1.Classes.SimptomeWrite;

namespace LB_II_1.Classes
{
    class ResourcesConfigEditClass
    {
        public static string GetProdjectDir()
        {
            Properties.Settings.Default.ExeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Properties.Settings.Default.Save();
            return Properties.Settings.Default.ExeDir;
        }

        public static string GetDatabaseDir()
        {
            Properties.Settings.Default.DBDir = Properties.Settings.Default.ExeDir + '\\' +
                                                Properties.Settings.Default.DBN + '\\' +
                                                Properties.Settings.Default.DBName;
            Properties.Settings.Default.TxtDir = Properties.Settings.Default.ExeDir + '\\' +
                                                Properties.Settings.Default.DBN + '\\' +
                                                Properties.Settings.Default.TxtName;
            Properties.Settings.Default.DBLog = Properties.Settings.Default.ExeDir + '\\' +
                                                Properties.Settings.Default.DBN + '\\' +
                                                Properties.Settings.Default.DBLogN;
            Properties.Settings.Default.Save();
            return Properties.Settings.Default.DBDir;
        }

        public static SYMPTOME[] StartStudy(SYMPTOME[] Sym)
        {
            using (StreamReader f = new StreamReader(Properties.Settings.Default.TxtDir))
            {
                //global::LB_II_1.Database.Resource.TeachResource
                string s;
                string[] sa;
                for(int j = 0; j < 75; ++j)
                {
                    s = f.ReadLine();
                    sa = s.Split(',');
                    Sym[j].New();
                    Sym[j].ID = 1;
                    Sym[j].ID = (sa[0] == "2") ? (short)2 : Sym[j].ID;
                    Sym[j].ID = (sa[0] == "3") ? (short)3 : Sym[j].ID;
                    Sym[j].ID = (sa[0] == "4") ? (short)4 : Sym[j].ID;
                    Sym[j].ID = (sa[0] == "5") ? (short)5 : Sym[j].ID;
                    Sym[j].Rheum= (sa[1] == "1") ? (true) : (false); 
                    Sym[j].Cough= (sa[2] == "1") ? (true) : (false); 
                    Sym[j].ASoreThroatPain= (sa[3] == "1") ? (true) : (false); 
                    Sym[j].FeverTemperature= (sa[4] == "1") ? (true) : (false); 
                    Sym[j].JointPain= (sa[5] == "1") ? (true) : (false); 
                    Sym[j].SoreThroat= (sa[6] == "1") ? (true) : (false); 
                    Sym[j].Sputum= (sa[7] == "1") ? (true) : (false); 
                    Sym[j].RattlingInLungs= (sa[8] == "1") ? (true) : (false); 
                    Sym[j].PainInLungs= (sa[9] == "1") ? (true) : (false); 
                    Sym[j].NotSay= (sa[10] == "1") ? (true) : (false); 
                }
             }
            return Sym;
        }
    }
}
