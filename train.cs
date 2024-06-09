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
    public partial class train : Form
    {
        public train()
        {
            InitializeComponent();
        }

        private void return_btn4_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submit_btn4_Click(object sender, EventArgs e)
        {
            int train_number = Int32.Parse(train_num_textbox.Text);
            int company_id = Int32.Parse(company_id_fk.Text);
            DateTime m_date = m_date_date.Value;
            
            int class1 = Int32.Parse(class_textbox.Text);
            int nofseats = Int32.Parse(num_of_seats_textbox.Text);
            string depart_id = depart_id_textbox.Text;
            string arrive_id = arrive_id_textbox.Text;
            string query = "INSERT INTO Train Values(@train_Number, @Company_ID, @M_Date, @Class1, @noOfSeats, @Depart_ID, @Arrive_ID)";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");

                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@train_Number", train_number);
                        cmd.Parameters.AddWithValue("@Company_ID", company_id);
                        cmd.Parameters.AddWithValue("@M_Date", m_date);
                        cmd.Parameters.AddWithValue("@Class1", class1);
                        cmd.Parameters.AddWithValue("@noOfSeats", nofseats);
                        cmd.Parameters.AddWithValue("@Depart_ID", depart_id);
                        cmd.Parameters.AddWithValue("@Arrive_ID", arrive_id);

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
    

            private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
