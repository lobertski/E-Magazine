using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MagazineSystem
{
    public partial class SubscriberProfile : UserControl
    {
        public SubscriberProfile()
        {
            InitializeComponent();
        }

        public void SubscriberProfile_Load(string customerID)
        {
            Subscribe get = new Subscribe();
        }



    }
}
