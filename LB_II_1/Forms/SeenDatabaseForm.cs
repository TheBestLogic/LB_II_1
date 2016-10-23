using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LB_II_1.Classes.DatabaseInteraction;
using static LB_II_1.Classes.SimptomeWrite;

namespace LB_II_1.Forms
{
    public partial class SeenDatabaseForm : Form
    {

        public SeenDatabaseForm(SqlConnection _Connection, bool GetLocale, Point Location)
        {
            SYMPTOME_COST[] SymC;
            InitializeComponent();
            SetTextLocale(GetLocale);
            this.Location = Location;
            GetData(_Connection, out SymC);
            FillTable(SymC);
        }
        
        private void GetData(SqlConnection Connection, out SYMPTOME_COST[] SymC)
        {
            SymC = new SYMPTOME_COST[5];
            for (int i = 0; i < 5; ++i)
                SymC[i].New();
            GetSoloOrAllTables(Connection, 6, SymCM: SymC);
        }
        
        private void FillTable(SYMPTOME_COST[] SymC)
        {
            for(int i = 0; i < 5; ++i)
            {
                if(SymC[i].ID<1 && SymC[i].ID > 4)
                {
                    MessageBox.Show("FillTable: ID error");
                    return;
                }
                dataGridView.Rows[0].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].ID);
                dataGridView.Rows[1].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].Rheum);
                dataGridView.Rows[2].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].Cough);
                dataGridView.Rows[3].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].ASoreThroatPain);
                dataGridView.Rows[4].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].FeverTemperature);
                dataGridView.Rows[5].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].JointPain);
                dataGridView.Rows[6].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].SoreThroat);
                dataGridView.Rows[7].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].Sputum);
                dataGridView.Rows[8].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].RattlingInLungs);
                dataGridView.Rows[9].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].PainInLungs);
                dataGridView.Rows[10].Cells[SymC[i].ID - 1].Value = Convert.ToString(SymC[i].NotSay);
            }
        }
    }
}
