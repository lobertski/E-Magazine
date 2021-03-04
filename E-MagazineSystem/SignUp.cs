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
using System.Drawing.Drawing2D;


namespace E_MagazineSystem
{
    public partial class SignUp : Form
    {
        int q = 0;
        public SignUp()
        {
            InitializeComponent();

        }

        private void TextboxFullName_Click(object sender, EventArgs e)
        {
            if (textboxFullName.Text == "Full Name:")
            {
                textboxFullName.Clear();
            }
        }

        private void TextboxFullName_Leave(object sender, EventArgs e)
        {
            if(textboxFullName.Text == "")
            {
                textboxFullName.Text = "Full Name:";
            }
        }

        private void TextBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username:")
            {
                textBoxUsername.Clear();
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username:";
            }
        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password:")
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '●';
            }        
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password:";
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '●';
            }
        }
        
        private void TextBoxCreditCard_Click(object sender, EventArgs e)
        {
            if (textBoxCreditCard.Text == "Credit Card #:")
            {
                textBoxCreditCard.Clear();
            }
        }

        private void TextBoxCreditCard_Leave(object sender, EventArgs e)
        {
            if (textBoxCreditCard.Text == "")
            {
                textBoxCreditCard.Text = "Credit Card #:";
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
                textBoxPassword.PasswordChar = '●';
        }

        private void TextBoxCreditCard_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCreditCard.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxCreditCard.Text = textBoxCreditCard.Text.Remove(textBoxCreditCard.Text.Length - 1);
            }
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textboxFullName.Text == "Full Name:" || textBoxUsername.Text == "Username:" || textBoxPassword.Text == "Password:" || textBoxPassword.Text == "Password:" || textBoxCreditCard.Text == "Credit Card #:")
                {
                    MessageBox.Show("Fill up all the information");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into CustomerInfo(fullName,username,password,birthDate,cardNumber) values('" + textboxFullName.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + bunifuDatepicker1.Value.ToString("M-d-yyyy") + "','" + textBoxCreditCard.Text + "')", con); ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("  Your account has been created!");
                    this.Close();
                }
            }
            catch { }

        }
    }
}
