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
            SymC = GetSoloOrAllTables(Connection, (int)flag, SymC);
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
            SymC.Rheum = Convert.ToInt16(dataGridView.Rows[1].Cells[0].Value);
            SymC.Cough = Convert.ToInt16(dataGridView.Rows[2].Cells[0].Value);
            SymC.ASoreThroatPain = Convert.ToInt16(dataGridView.Rows[3].Cells[0].Value);
            SymC.FeverTemperature = Convert.ToInt16(dataGridView.Rows[4].Cells[0].Value);
            SymC.JointPain = Convert.ToInt16(dataGridView.Rows[5].Cells[0].Value);
            SymC.SoreThroat = Convert.ToInt16(dataGridView.Rows[6].Cells[0].Value);
            SymC.Sputum = Convert.ToInt16(dataGridView.Rows[7].Cells[0].Value);
            SymC.RattlingInLungs = Convert.ToInt16(dataGridView.Rows[8].Cells[0].Value);
            SymC.PainInLungs = Convert.ToInt16(dataGridView.Rows[9].Cells[0].Value);
            SymC.NotSay = Convert.ToInt16(dataGridView.Rows[10].Cells[0].Value);
            if(SupperRootCheckBox.Checked)
            {
                UpdateTable(Connection, SymC: SymC);
            }
            else
            {
                UpdateTable(Connection, flag, SymC);
            }
        }
        

        private void DeseareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetButton.Enabled = true;
            SetButton.Enabled = true;
            flag = 0;
            switch (DeseareComboBox.SelectedIndex)
            {
                case 0:
                    flag = 1;
                    if (Locale)
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_ENG.Pne;
                    }
                    else
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_RU.Pne;
                    }
                    break;
                case 1:
                    flag = 2;
                    if (Locale)
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_ENG.Ang;
                    }
                    else
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_RU.Ang;
                    }
                    break;
                case 2:
                    flag = 3;
                    if (Locale)
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_ENG.Flu;
                    }
                    else
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_RU.Flu;
                    }
                    break;
                case 3:
                    flag = 4;
                    if (Locale)
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_ENG.Pha;
                    }
                    else
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_RU.Pha;
                    }
                    break;
                case 4:
                    flag = 5;
                    if (Locale)
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_ENG.Bro;
                    }
                    else
                    {
                        dataGridView.Columns[0].HeaderText = Local.Local_RU.Bro;
                    }
                    break;
                default:
                    break;
                
            }
        }
    }
}
