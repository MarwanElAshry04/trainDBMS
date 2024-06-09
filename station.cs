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
    public partial class station : Form
    {
        public station()
        {
            InitializeComponent();
        }

        private void returnbtn2_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submitbtn2_Click(object sender, EventArgs e)
        {
            string s_id = s_id_textbox.Text;
            string s_name = s_name_textbox.Text;
            string s_location = s_location_textbox.Text;
            string query = "INSERT INTO Station Values(@s_ID, @s_Name, @s_Location)";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@s_ID", s_id);
                        cmd.Parameters.AddWithValue("@s_Name", s_name);
                        cmd.Parameters.AddWithValue("@s_Location", s_location);

                        int exe = cmd.ExecuteNonQuery();
                        if (exe != 0)
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

