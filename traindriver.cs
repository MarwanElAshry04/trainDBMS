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
    public partial class traindriver : Form
    {
        public traindriver()
        {
            InitializeComponent();
        }

        private void returnbtn3_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submitdriver_btn_Click(object sender, EventArgs e)
        {
            int driver_id = Convert.ToInt32(driver_id_texbox.Text);
            string fname = fname_driver_textbox.Text;
            string lname = lastname_driver_textbox.Text;
            string query = "INSERT INTO Train_Driver Values(@driver_ID, @fName, @lName)";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@driver_id", driver_id);
                        cmd.Parameters.AddWithValue("@fName", fname);
                        cmd.Parameters.AddWithValue("@lName", lname);
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
