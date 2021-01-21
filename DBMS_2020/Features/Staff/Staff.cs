using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020.Class;

namespace DBMS_2020.Features.Staff
{
    public partial class Staff : UserControl
    {
        private InforStaff inforStaff;
        private Sell sell;
        public Staff()
        {
            InitializeComponent();
            //loadInforStaff();
            //loadSell();
        }
        private void loadInforStaff()
        {
            this.inforStaff = new InforStaff();
            MethodHelps.addControl(this.pnl_load, this.inforStaff); ;
        }
        private void loadSell()
        {
            this.sell = new Sell();
            MethodHelps.addControl(this.pnl_load, this.sell);
        }

      

        private void lbl_InfoStaff_Click(object sender, EventArgs e)
        {
            loadInforStaff();
            if (!(this.sell is null)) this.sell.Dispose();
        }

        private void lbl_Sell_Click(object sender, EventArgs e)
        {
            loadSell();
            if (!(this.inforStaff is null)) this.inforStaff.Dispose();
        }
    }
}
