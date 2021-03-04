using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace E_MagazineSystem
{
    public partial class Subscribe : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
        string publisher, magID; int issueNo;
        public Subscribe()
        {
            InitializeComponent();
            comboBoxNoOfMonths.Text = "Number of months of subscription";
        }

        public void Subscribe_Load(int IssueNo, string Publisher)
        {
            labelIssueNo.Text = "Issue #" + IssueNo;
            labelMagName.Text = Publisher + " Magazine";
            publisher = Publisher; issueNo = IssueNo;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select magazineImage from MagazineInfo where [publisher]='" + Publisher + "' AND Issue#='" + IssueNo + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Lobertski\\Desktop\\LOBERTSKI\\School\\SAD\\Magazines\\" + dr.GetValue(0).ToString());
                break;
            }
            con.Close();
        }

        private void ComboBoxNoOfMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            SubscriberHome get = new SubscriberHome();
            MainControlClass get1 = new MainControlClass();
            Home get3 = new Home();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select magazineID from MagazineInfo where [publisher]='" + publisher + "' AND Issue#='"+issueNo+"' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                magID = dr.GetValue(0).ToString();
                break;
            }
            con.Close();

            List<string> linesData = File.ReadAllLines(get1.tempCustomerIDLoc).ToList();
            foreach (var line in linesData)
            {
                string[] entries = line.Split(',');
                get1.CustomerID = entries[0];
                break;
            }

            if (comboBoxNoOfMonths.SelectedIndex == 0)
            {
                con.Open();
                SqlCommand cmdr0 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+"','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(30).ToString("M-d-yyyy")+"')", con);
                cmdr0.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }

            else if (comboBoxNoOfMonths.SelectedIndex == 1)
            {
                con.Open();
                SqlCommand cmdr1 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+"','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(60).ToString("M-d-yyyy")+"')", con);
                cmdr1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }


            else if (comboBoxNoOfMonths.SelectedIndex == 2)
            {
                con.Open();
                SqlCommand cmdr2 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+ "','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(90).ToString("M-d-yyyy")+"')", con);
                cmdr2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }


            else if (comboBoxNoOfMonths.SelectedIndex == 3)
            {
                con.Open();
                SqlCommand cmdr3 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+"','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(120).ToString("M-d-yyyy")+"')", con);
                cmdr3.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }

            else if (comboBoxNoOfMonths.SelectedIndex == 4)
            {
                con.Open();
                SqlCommand cmdr4 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+"','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(150).ToString("M-d-yyyy")+"')", con);
                cmdr4.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }

            else if (comboBoxNoOfMonths.SelectedIndex == 5)
            {
                con.Open();
                SqlCommand cmdr5 = new SqlCommand("Insert Into Subscription values('"+get1.CustomerID+"','"+Int32.Parse(magID)+"','"+DateTime.Now.ToString("M-d-yyyy")+"','"+DateTime.Now.AddDays(180).ToString("M-d-yyyy")+"')", con);
                cmdr5.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Subscription Success!");
                MainControlClass.showControl(get3, Content);
            }

            else
            {
                MessageBox.Show("Select how many months to subscribe");
            }

        }
    }
}
