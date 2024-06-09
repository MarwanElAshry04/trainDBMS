using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database1
{
    public partial class train_companies : Form
    {
        public train_companies()
        {
            InitializeComponent();
        }

        private void return_btn11_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void display_btn6_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string sql = @"SELECT T.TRAIN_NUMBER, TC.COMPANY_NAME FROM TRAIN_COMPANY TC INNER JOIN TRAIN T ON TC.COMPANY_ID = T.COMPANY_ID;";


                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }  
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void train_company_label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
