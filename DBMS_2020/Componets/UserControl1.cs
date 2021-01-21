using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_2020.Componets
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.Rows.Add("4", "4", "4", "4");

            gunaDataGridView1.Rows.Add("4", "4", "4", "4");




            gunaDataGridView1.Rows.Add("4", "4", "4", "4");
            gunaDataGridView1.Rows.Add("4", "4", "4", "4");
            gunaDataGridView1.Rows.Add("4", "4", "4", "4");
            gunaDataGridView1.Rows.Add("4", "4", "4", "4");
        }
    }
}
