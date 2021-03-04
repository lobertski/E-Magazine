using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MagazineSystem
{
    class MainControlClass
    {
        string customerID, tempIDLoc =@"C:\Users\Lobertski\Desktop\LOBERTSKI\School\SAD\tempCustomerID.csv";
        public static void showControl(System.Windows.Forms.Control control , System.Windows.Forms.Control Content)
        {

                Content.Controls.Clear();
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();
                Content.Controls.Add(control);
        }

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string tempCustomerIDLoc
        {
            get { return tempIDLoc; }
            set { tempIDLoc = value; }
        }
    }
}
