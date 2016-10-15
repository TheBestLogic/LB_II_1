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
        public SymptomCostSetForm(SqlConnection Connection, bool GetLocale, Point Location)
        {
            InitializeComponent();
            this.Location = Location;
            SetTextLocale(GetLocale);
        }
    }
}
