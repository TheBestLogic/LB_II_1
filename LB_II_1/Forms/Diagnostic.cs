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

namespace LB_II_1.Forms
{
    public partial class Diagnostic : Form
    {
        public Diagnostic(SqlConnection Connection, bool GetLocale, Point Location)
        {
            InitializeComponent();
            SetTextLocale(GetLocale);
            this.Location = Location;
        }
    }
}
