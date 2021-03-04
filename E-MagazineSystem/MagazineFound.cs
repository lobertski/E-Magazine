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
    public partial class MagazineFound : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
        string PublisherName;
        int magazine1, magazine2, magazine3;
        public MagazineFound()
        {
            InitializeComponent();
        }

        public void MagazineFound_Load(string Publisher)
        {
            labelMagazinePublisher.Text = Publisher + " Magazine";
            PublisherName = Publisher;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select magazineImage, magazineID from MagazineInfo where [publisher]='" + Publisher + "' AND Issue#='1' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Lobertski\\Desktop\\LOBERTSKI\\School\\SAD\\Magazines\\" + dr.GetValue(0).ToString());
                    magazine1 = Convert.ToInt32(dr.GetValue(1).ToString());
                    break;
                }
                con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select magazineImage, magazineID from MagazineInfo where [publisher]='" + Publisher + "' AND Issue#='2' ", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\Lobertski\\Desktop\\LOBERTSKI\\School\\SAD\\Magazines\\" + dr2.GetValue(0).ToString());
                magazine2 = Convert.ToInt32(dr2.GetValue(1).ToString());
                break;
            }
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select magazineImage, magazineID from MagazineInfo where [publisher]='" + Publisher + "' AND Issue#='3' ", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                pictureBox3.Image = Image.FromFile("C:\\Users\\Lobertski\\Desktop\\LOBERTSKI\\School\\SAD\\Magazines\\" + dr3.GetValue(0).ToString());
                magazine3 = Convert.ToInt32(dr3.GetValue(1).ToString());
                break;
            }
            con.Close();
        }

        private void ButtonSubscribe1_Click_1(object sender, EventArgs e)
        {
            Subscribe get = new Subscribe();
            get.Subscribe_Load(1,PublisherName);
            MainControlClass.showControl(get, Content);
        }

        private void ButtonSubscribe2_Click(object sender, EventArgs e)
        {
            Subscribe get = new Subscribe();
            get.Subscribe_Load(2,PublisherName);
            MainControlClass.showControl(get, Content);
        }
        
        private void ButtonSubscribe3_Click(object sender, EventArgs e)
        {
            Subscribe get = new Subscribe();
            get.Subscribe_Load(3,PublisherName);
            MainControlClass.showControl(get, Content);
        }

        private void MagazineFound_Load(object sender, EventArgs e)
        {
            MainControlClass get1 = new MainControlClass();
            List<string> linesData = File.ReadAllLines(get1.tempCustomerIDLoc).ToList();
            foreach (var line in linesData)
            {
                string[] entries = line.Split(',');
                get1.CustomerID = entries[0];
                break;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("Select magazineID from Subscription where dateEnded > @dateNow AND customerID = @costomerID AND magazineID =@magID", con);
            cmd.Parameters.Add("@dateNow", DateTime.Now);
            cmd.Parameters.Add("@costomerID", get1.CustomerID);
            cmd.Parameters.Add("@magID", magazine1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr[0].ToString().Trim()) == magazine1)
                {
                    buttonSubscribe1.Text = "Subscribed";
                    buttonSubscribe1.Enabled = false;
                }
                break;
            }
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select magazineID from Subscription where dateEnded > @dateNow AND customerID = @costomerID AND magazineID =@magID", con);
            cmd2.Parameters.Add("@dateNow", DateTime.Now);
            cmd2.Parameters.Add("@costomerID", get1.CustomerID);
            cmd2.Parameters.Add("@magID", magazine2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                if (Convert.ToInt32(dr2[0].ToString().Trim()) == magazine2)
                {
                    buttonSubscribe2.Text = "Subscribed";
                    buttonSubscribe2.Enabled = false;
                }
                break;
            }
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select magazineID from Subscription where dateEnded > @dateNow AND customerID = @costomerID AND magazineID =@magID", con);
            cmd3.Parameters.Add("@dateNow", DateTime.Now);
            cmd3.Parameters.Add("@costomerID", get1.CustomerID);
            cmd3.Parameters.Add("@magID", magazine3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                if (Convert.ToInt32(dr3[0].ToString().Trim()) == magazine3)
                {
                    buttonSubscribe3.Text = "Subscribed";
                    buttonSubscribe3.Enabled = false;
                }
                break;
            }
            con.Close();
        }
    }
}
