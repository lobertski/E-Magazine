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
    public partial class ReadPDF : Form
    {
        string pdfName;
        public ReadPDF()
        {
            InitializeComponent();
        }

        public void ReadPDF_Load(string MagName)
        {
            pdfName = MagName;
        }

        private void ReadPDF_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [magazinePDFpath] from MagazineInfo where [magazineName]='"+pdfName+"' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.FileName = "C:\\Users\\Lobertski\\Desktop\\LOBERTSKI\\School\\SAD\\Magazines\\"+dr.GetValue(0).ToString();
                axAcroPDF1.LoadFile(dlg.FileName);
                break;
            }
            con.Close();
        }
    }
}
