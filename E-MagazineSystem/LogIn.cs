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
using System.IO;

namespace E_MagazineSystem
{
    public partial class LogIn : Form
    {
        int q; string customerID;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
        public LogIn()
        {
            MainControlClass get1 = new MainControlClass();
            List<string> linesData = File.ReadAllLines(get1.tempCustomerIDLoc).ToList();
            foreach (var line in linesData)
            {
                string[] entries = line.Split(',');
                linesData.Remove(line);
                break;
            }
            File.WriteAllLines(get1.tempCustomerIDLoc, linesData);
            InitializeComponent();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username:")
            {
                textBoxUsername.Clear();
                panel1.BackColor = Color.FromArgb(35, 52, 70);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp get = new SignUp();
            get.ShowDialog();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text =="Username:" || textBoxPassword.Text =="Password:")
            {
                MessageBox.Show("Enter your Username or Password");
            }

            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select password From CustomerInfo where username='"+textBoxUsername.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString().Trim() == textBoxPassword.Text)
                    {
                        q = 1;
                        break;
                    }
                }
                con.Close();

                if (q == 1)
                {
                    MainControlClass get1 = new MainControlClass();
                    List<string> linesData = File.ReadAllLines(get1.tempCustomerIDLoc).ToList();
                    con.Open();
                    SqlCommand cmdr = new SqlCommand("select customerID from CustomerInfo where username='" + textBoxUsername.Text + "'", con);
                    SqlDataReader drr = cmdr.ExecuteReader();
                    while (drr.Read())
                    {
                        customerID = drr[0].ToString();
                        linesData.Add(customerID);
                        File.WriteAllLines(get1.tempCustomerIDLoc, linesData);
                    }
                    con.Close();

                    foreach (var line in linesData)
                    {
                        string[] entries = line.Split(',');
                        get1.CustomerID = entries[0];
                        break;
                    }

                    SubscriberHome get = new SubscriberHome();
                    get.SubscriberHome_Load(textBoxUsername.Text);
                    get.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                con.Close();
            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username:";
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
            panel2.BackColor = Color.FromArgb(35, 52, 70);
        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password:")
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '●';
                panel2.BackColor = Color.FromArgb(35, 52, 70);
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password:";
                textBoxPassword.PasswordChar = '\0';
                panel2.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                textBoxPassword.PasswordChar = '●';
            }
        }
    }
}
