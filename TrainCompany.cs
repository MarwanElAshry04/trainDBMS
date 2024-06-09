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
    public partial class TrainCompany : Form
    {
        public TrainCompany()
        {
            InitializeComponent();
        }

        private void TrainCompany_Load(object sender, EventArgs e)
        {
        }

        private void gobackbutton_Click(object sender, EventArgs e)
        {

            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submitcompanybtn_Click(object sender, EventArgs e)
        {
            int c_id = Convert.ToInt32(c_id_textbox.Text);
            string c_name = c_name_textbox.Text;
            string query = "INSERT INTO Train_Company Values(@c_ID, @c_Name)";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@c_ID", c_id);
                        cmd.Parameters.AddWithValue("@c_Name", c_name);

                        int exe = cmd.ExecuteNonQuery();
                        if (exe > 0)
                        {
                            MessageBox.Show("Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}


