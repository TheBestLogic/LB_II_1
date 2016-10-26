using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_II_1.Classes;
using static LB_II_1.Classes.SimptomeWrite;
using static LB_II_1.Classes.DatabaseInteraction;

namespace LB_II_1.Forms
{
    public partial class Diagnostic : Form
    {
        private SYMPTOME Sym;
        public SqlConnection Connection;
        bool Locale;

        public Diagnostic(SqlConnection _Connection, bool GetLocale, Point Location)
        {
            Connection = _Connection;
            InitializeComponent();
            SetTextLocale(GetLocale);
            this.Location = Location;
            Locale = GetLocale;
            Sym.Clear();
        }

        private void Rheum_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.Rheum = !Sym.Rheum;
        }

        private void FeverTemperature_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.FeverTemperature = !Sym.FeverTemperature;
        }

        private void JointPain_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.JointPain = !Sym.JointPain;
        }

        private void ASoreThroatPain_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.ASoreThroatPain = !Sym.ASoreThroatPain;
        }

        private void SoreThroat_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.SoreThroat = !Sym.SoreThroat;
        }

        private void NotSay_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.NotSay = !Sym.NotSay;
        }

        private void Cough_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.Cough = !Sym.Cough;
        }

        private void RattlingInLungs_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.RattlingInLungs = !Sym.RattlingInLungs;
        }

        private void PainInLungs_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.PainInLungs = !Sym.PainInLungs;
        }

        private void Sputum_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Sym.Sputum = !Sym.Sputum;
        }

        private void Diagnostic_button_Click(object sender, EventArgs e)
        {
            EnabledFunction();
            textBox.Text = "";
            SYMPTOME_COST[] SymC = new SYMPTOME_COST[5];
            GetSoloOrAllTables(Connection, 6, SymCM: SymC);
            Thread.Sleep(300);
            int Fl = GetSum(ref Sym, ref SymC);
            if (Locale)
            {
                textBox.Text += Local.Local_ENG.Massage+' ';
                switch (Fl)
                {
                    case 1:
                        textBox.Text += Local.Local_ENG.Pne;
                        break;
                    case 2:
                        textBox.Text += Local.Local_ENG.Ang;
                        break;
                    case 3:
                        textBox.Text += Local.Local_ENG.Flu;
                        break;
                    case 4:
                        textBox.Text += Local.Local_ENG.Pha;
                        break;
                    case 5:
                        textBox.Text += Local.Local_ENG.Bro;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                textBox.Text += Local.Local_RU.Massage;
                switch (Fl)
                {
                    case 1:
                        textBox.Text += Local.Local_RU.Pne;
                        break;
                    case 2:
                        textBox.Text += Local.Local_RU.Ang;
                        break;
                    case 3:
                        textBox.Text += Local.Local_RU.Flu;
                        break;
                    case 4:
                        textBox.Text += Local.Local_RU.Pha;
                        break;
                    case 5:
                        textBox.Text += Local.Local_RU.Bro;
                        break;
                    default:
                        break;
                }
            }
            UpdateTable(Connection, Fl, SymC[Fl-1]);
            Thread.Sleep(300);
            EnabledFunction();
        }

        private void EnabledFunction()
        {
            this.Rheum_checkBox.Enabled = !this.Rheum_checkBox.Enabled;
            this.FeverTemperature_checkBox.Enabled = !this.FeverTemperature_checkBox.Enabled;
            this.JointPain_checkBox.Enabled = !this.JointPain_checkBox.Enabled;
            this.ASoreThroatPain_checkBox.Enabled = !this.ASoreThroatPain_checkBox.Enabled;
            this.SoreThroat_checkBox.Enabled = !this.SoreThroat_checkBox.Enabled;
            this.NotSay_checkBox.Enabled = !this.NotSay_checkBox.Enabled;
            this.Cough_checkBox.Enabled = !this.Cough_checkBox.Enabled;
            this.RattlingInLungs_checkBox.Enabled = !this.RattlingInLungs_checkBox.Enabled;
            this.PainInLungs_checkBox.Enabled = !this.PainInLungs_checkBox.Enabled;
            this.Sputum_checkBox.Enabled = !this.Sputum_checkBox.Enabled;
            this.Diagnostic_button.Enabled = !this.Diagnostic_button.Enabled;
        }
    }
}
