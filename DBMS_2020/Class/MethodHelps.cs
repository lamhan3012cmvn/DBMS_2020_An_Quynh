using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_2020.Class
{
    public class MethodHelps
    {
        public static void addControl(Control control_parent, Control control_child)
        {
            //control_parent.Controls.Clear();
            control_parent.Controls.Add(control_child);
            control_child.Dock = DockStyle.Fill;
            control_child.BringToFront();
            MessageBox.Show(control_parent.Controls.Count.ToString());
        }
    }
}
