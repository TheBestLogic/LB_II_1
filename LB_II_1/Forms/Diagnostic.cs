﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LB_II_1.Classes.SimptomeWrite;

namespace LB_II_1.Forms
{
    public partial class Diagnostic : Form
    {
        private SYMPTOME Sym;

        public Diagnostic(SqlConnection Connection, bool GetLocale, Point Location)
        {
            InitializeComponent();
            SetTextLocale(GetLocale);
            this.Location = Location;
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
    }
}
