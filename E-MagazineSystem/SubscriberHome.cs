using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_MagazineSystem
{
    public partial class SubscriberHome : Form
    {
        public SubscriberHome()
        {
            InitializeComponent();
            sidePanel.Height = bunifuFlatButton1.Height;
            sidePanel.Top = bunifuFlatButton1.Top;
            Home get = new Home();
            MainControlClass.showControl(get, Content);
        }

        public void SubscriberHome_Load(string Username)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select customerID,fullName from CustomerInfo where username='"+Username+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                labelCustomeName.Text = dr.GetValue(1).ToString();
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        { 
            sidePanel.Height = bunifuFlatButton1.Height;
            sidePanel.Top = bunifuFlatButton1.Top;
            Home get = new Home();
            MainControlClass.showControl(get, Content);
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = bunifuFlatButton2.Height;
            sidePanel.Top = bunifuFlatButton2.Top;
            Browse gs = new Browse();
            MainControlClass.showControl(gs, Content);
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = bunifuFlatButton3.Height;
            sidePanel.Top = bunifuFlatButton3.Top;
            SelectMagazineRead get = new SelectMagazineRead();
            MainControlClass.showControl(get, Content);
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = bunifuFlatButton4.Height;
            sidePanel.Top = bunifuFlatButton4.Top;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
