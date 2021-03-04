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
    public partial class Browse : UserControl
    {
        int q;
        public Browse()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select publisher from MagazineInfo where [publisher]='" + textBox1.Text + "'";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0].ToString().Trim() == textBox1.Text)
                {
                    q = 1;
                    break;
                }
            }
            if (q == 1)
            {
                MagazineFound ts = new MagazineFound();
                ts.MagazineFound_Load(textBox1.Text);
                MainControlClass.showControl(ts, Content);
                con.Close();
            }
            else
            {

                Notfound get = new Notfound();
                MainControlClass.showControl(get, Content);
            }
            con.Close();

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " Search by Publisher Name")
            {
                textBox1.Clear();
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = " Search by Publisher Name";
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(1, e);
            }
        }
    }
}
