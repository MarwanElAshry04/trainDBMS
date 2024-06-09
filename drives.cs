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
    public partial class drives : Form
    {
        public drives()
        {
            InitializeComponent();
        }

        private void return_btn6_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submit_btn6_Click(object sender, EventArgs e)
        {
            int t_number = Int32.Parse(drives_tnum_textbox.Text);
            int c_number = Int32.Parse(drives_cid_textbox.Text);
            int driver_id = Int32.Parse(drives_did_textbox.Text);

            string query = "INSERT INTO Drives Values (@t_Number, @c_Number, @driver_ID)";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@t_Number", t_number);
                        cmd.Parameters.AddWithValue("@c_Number", c_number);
                        cmd.Parameters.AddWithValue("@driver_ID", driver_id);

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

            catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }




        }
    }
}
