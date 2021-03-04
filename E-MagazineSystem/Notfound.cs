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

namespace E_MagazineSystem
{
    public partial class Notfound : UserControl
    {
        int q;
        public Notfound()
        {
            InitializeComponent();    
        }

        private void TextboxFullName_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search by Publisher Magazine Name")
            {
                textBoxSearch.Clear();
            }
        }

        private void TextboxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Search by Publisher Magazine Name";
            }
        }

        private void Notfound_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((panel1.Width - pictureBox1.Size.Width) / 2, (panel1.Height - pictureBox1.Size.Height) / 2);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select publisher from MagazineInfo where [publisher]='"+textBoxSearch.Text+"'";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0].ToString().Trim() == textBoxSearch.Text)
                {
                    q = 1;
                    break;
                }
            }
            if (q == 1)
            {
                MagazineFound ts = new MagazineFound();
                ts.MagazineFound_Load(textBoxSearch.Text);
                MainControlClass.showControl(ts, Content);
            }
            else
            {

            }
            con.Close();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == " Search by Publisher Name")
            {
                textBoxSearch.Clear();
            }
        }

        private void TextBoxSearch_Leave_1(object sender, EventArgs e)
        { 
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = " Search by Publisher Name";
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(1, e);
            }
        }
    }
}
