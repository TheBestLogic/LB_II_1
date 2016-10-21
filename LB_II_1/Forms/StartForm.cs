using LB_II_1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LB_II_1.Classes.DatabaseInteraction;
using static LB_II_1.Classes.SimptomeWrite;

namespace LB_II_1
{
    public partial class StartForm : Form
    {
        public SqlConnection Connection;
        private bool Locale;

        public StartForm()
        {
            Locale = true;
            InitializeComponent();
            SetTextLocale(Locale);
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            SYMPTOME_COST[] SymC = new SYMPTOME_COST[5];
            Connection = CreateConn(Connection);
            NeedNewTables(Connection);
        }

        private void StatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LostConn(Connection);
        }

        private void SymptomeEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SymptomCostSetForm _SymptomCostSetForm = new SymptomCostSetForm(Connection, Locale, Location);
            _SymptomCostSetForm.ShowDialog();
            this.Visible = true;
        }

        private void SeenDatabase_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SeenDatabaseForm _SeenDatabaseForm = new SeenDatabaseForm(Connection, Locale, Location);
            _SeenDatabaseForm.ShowDialog();
            this.Visible = true;
        }

        private void Diagnostic_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Diagnostic _Diagnostic = new Diagnostic(Connection, Locale, Location);
            _Diagnostic.ShowDialog();
            this.Visible = true;
        }

        private void Local_button_Click(object sender, EventArgs e)
        {
            Locale = !Locale;
            SetTextLocale(Locale);
        }
    }
}
