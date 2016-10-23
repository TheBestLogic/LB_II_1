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
    public partial class SymptomCostSetForm : Form
    {
        private bool Locale;
        private short flag;
        SqlConnection Connection;
        public SymptomCostSetForm(SqlConnection _Connection, bool GetLocale, Point Location)
        {
            Locale = GetLocale;
            Connection = _Connection;
            InitializeComponent();
            this.Location = Location;
            SetTextLocale(GetLocale);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            SYMPTOME_COST SymC = new SYMPTOME_COST();
            SymC.New();
            if (SupperRootCheckBox.Checked)
            {
                SymC = GetSoloOrAllTables(Connection, SymC: SymC);
            }
            else
            {
                SymC = GetSoloOrAllTables(Connection, (int)flag, SymC);
            }
            dataGridView.Rows[0].Cells[0].Value = Convert.ToString(SymC.ID);
            dataGridView.Rows[1].Cells[0].Value = Convert.ToString(SymC.Rheum);
            dataGridView.Rows[2].Cells[0].Value = Convert.ToString(SymC.Cough);
            dataGridView.Rows[3].Cells[0].Value = Convert.ToString(SymC.ASoreThroatPain);
            dataGridView.Rows[4].Cells[0].Value = Convert.ToString(SymC.FeverTemperature);
            dataGridView.Rows[5].Cells[0].Value = Convert.ToString(SymC.JointPain);
            dataGridView.Rows[6].Cells[0].Value = Convert.ToString(SymC.SoreThroat);
            dataGridView.Rows[7].Cells[0].Value = Convert.ToString(SymC.Sputum);
            dataGridView.Rows[8].Cells[0].Value = Convert.ToString(SymC.RattlingInLungs);
            dataGridView.Rows[9].Cells[0].Value = Convert.ToString(SymC.PainInLungs);
            dataGridView.Rows[10].Cells[0].Value = Convert.ToString(SymC.NotSay);
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SYMPTOME_COST SymC = new SYMPTOME_COST();
            SymC.New();
            SymC.ID = flag;
            SymC.Rheum = Correct(Convert.ToString(dataGridView.Rows[1].Cells[0].Value));
            SymC.Cough = Correct(Convert.ToString(dataGridView.Rows[2].Cells[0].Value));
            SymC.ASoreThroatPain = Correct(Convert.ToString(dataGridView.Rows[3].Cells[0].Value));
            SymC.FeverTemperature = Correct(Convert.ToString(dataGridView.Rows[4].Cells[0].Value));
            SymC.JointPain = Correct(Convert.ToString(dataGridView.Rows[5].Cells[0].Value));
            SymC.SoreThroat = Correct(Convert.ToString(dataGridView.Rows[6].Cells[0].Value));
            SymC.Sputum = Correct(Convert.ToString(dataGridView.Rows[7].Cells[0].Value));
            SymC.RattlingInLungs = Correct(Convert.ToString(dataGridView.Rows[8].Cells[0].Value));
            SymC.PainInLungs = Correct(Convert.ToString(dataGridView.Rows[9].Cells[0].Value));
            SymC.NotSay = Correct(Convert.ToString(dataGridView.Rows[10].Cells[0].Value));
            if(SupperRootCheckBox.Checked)
            {
                UpdateTable(Connection, SymC: SymC);
            }
            else
            {
                UpdateTable(Connection, flag, SymC);
            }
        }
        
        private static short Correct(string String)
        {
            for(int i = 0; i < String.Length; ++i)
            {
                if(!Char.IsDigit(String,i))
                {
                    return 0;
                }
            }
            return Convert.ToInt16(String);
        }

        

        private void DeseareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetButton.Enabled = true;
            SetButton.Enabled = true;
        }
    }
}
