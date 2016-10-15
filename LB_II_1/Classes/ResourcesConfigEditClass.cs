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
            Properties.Settings.Default.DBLog = Properties.Settings.Default.ExeDir + '\\' +
                                                Properties.Settings.Default.DBN + '\\' +
                                                Properties.Settings.Default.DBLogN;
            Properties.Settings.Default.Save();
            return Properties.Settings.Default.DBDir;
        }
    }
}
