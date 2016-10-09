using LB_II_1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_II_1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StatForm_Load(object sender, EventArgs e)
        {

        }

        private void StatForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SymptomeEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SymptomCostSetForm _SymptomCostSetForm = new SymptomCostSetForm();
            _SymptomCostSetForm.ShowDialog();
            this.Visible = true;
        }

        private void SeenDatabase_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SeenDatabaseForm _SeenDatabaseForm = new SeenDatabaseForm();
            _SeenDatabaseForm.ShowDialog();
            this.Visible = true;
        }

        private void Diagnostic_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Diagnostic _Diagnostic = new Diagnostic();
            _Diagnostic.ShowDialog();
            this.Visible = true;
        }
    }
}
