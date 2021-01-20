using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020.Features;
using DBMS_2020.Class;
namespace DBMS_2020
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Index mainUI = new Index();
            MethodHelps.addControl(this.pnl_FormMain, mainUI);
        }
    }
}
