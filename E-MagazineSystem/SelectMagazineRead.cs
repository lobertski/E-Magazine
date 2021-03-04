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
    public partial class SelectMagazineRead : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-D2ICRPB;Initial Catalog=eMagazine;Integrated Security=True");
        MainControlClass get1 = new MainControlClass();

        int j;
        string[] arr = new string[100];
        public SelectMagazineRead()
        {
            InitializeComponent();

            foreach (DataGridViewColumn item in bunifuDataGridView.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }


        private void SelectMagazineRead_Load(object sender, EventArgs e)
        {


            List<string> linesData = File.ReadAllLines(get1.tempCustomerIDLoc).ToList();
            foreach (var line in linesData)
            {
                string[] entries = line.Split(',');
                get1.CustomerID = entries[0];
                break;
            }

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select [dateStarted],[dateEnded],[magazineID] from Subscription where [customerID]='" + get1.CustomerID + "' AND dateEnded > @dateNow ", con);
            da.SelectCommand.Parameters.AddWithValue("@dateNow", DateTime.Now);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[i] = dr["magazineID"].ToString();
                    con.Close();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select magazineName,publisher from MagazineInfo where magazineID = @magID", con);
                    cmd.Parameters.Add("@magID", arr[i]);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    string[] row1 = new string[] { i.ToString() };
                    j = i;

                    bunifuDataGridView.Rows.Add(row1);
                    bunifuDataGridView.Rows[i].Cells[0].Value = null;

                    while (dr1.Read())
                    {

                        bunifuDataGridView.Rows[i].Cells[1].Value = dr1[0].ToString();
                        bunifuDataGridView.Rows[i].Cells[2].Value = dr1[1].ToString();
                        bunifuDataGridView.Rows[i].Cells[3].Value = /*dr["dateStarted"].ToString()*/   Convert.ToDateTime(dr["dateStarted"]).ToString("MMMM dd, yyyy");
                        bunifuDataGridView.Rows[i].Cells[4].Value =   Convert.ToDateTime(dr["dateEnded"]).ToString("MMMM dd, yyyy");
                    }
                }
            }
            catch(Exception ex)

            { }
        }


        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bunifuDataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkedCell = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkedCell.Value) == true)
                {
                    ReadPDF get = new ReadPDF();
                    get.ReadPDF_Load(row.Cells[1].Value.ToString());
                    get.Show();
                }

                //else if (Convert.ToBoolean(checkedCell.Value) == false)
                //{
                //    MessageBox.Show("Select Magazine to Read");
                //    break;
                //}
            }
        }

        private void BunifuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in bunifuDataGridView.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells[0].Value = !Convert.ToBoolean(row.Cells[0].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }
    }  
}
