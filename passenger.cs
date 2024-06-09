using System;
using System.Collections;
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
    public partial class passenger : Form
    {
        public passenger()
        {
            InitializeComponent();
        }

        private void return_btn5_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void passenger_id_label_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn5_Click(object sender, EventArgs e)
        {
            int pass_id = Int32.Parse(pass_id_textbox.Text);
            string pass_fname = pass_fname_textbox.Text;
            string pass_lname = pass_lname_textbox.Text;
            string query = "INSERT INTO Passenger Values (@pass_ID, @pass_Fname, @pass_Lname)";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");

                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pass_ID", pass_id);
                        cmd.Parameters.AddWithValue("@pass_Fname", pass_fname);
                        cmd.Parameters.AddWithValue("@pass_Lname", pass_lname);

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
