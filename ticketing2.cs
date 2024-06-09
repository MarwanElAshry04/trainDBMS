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
    public partial class ticketing2 : Form
    {
        public ticketing2()
        {
            InitializeComponent();
        }

        private void return_btn_7_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void submit_btn_6_Click(object sender, EventArgs e)
        {
            int ticket_number = Int32.Parse(tk_num_textbox.Text);
            DateTime purchase_date = p_date_picker.Value;
            int ticket_price = Int32.Parse(price_textbox.Text);
            int tk_train = Int32.Parse(tk_train_textbox.Text);
            int tk_company = Int32.Parse(company_tick_textbox.Text);
            int tk_passenger = Int32.Parse(passenger_id_tick.Text);

            string query = "INSERT INTO Ticketing Values (@Ticket_number, @Purchase_date, @Ticket_price, @tk_Train, @tk_Company, @tk_Passenger)";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");

                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ticket_number", ticket_number);
                        cmd.Parameters.AddWithValue("@Purchase_date", purchase_date);
                        cmd.Parameters.AddWithValue("@Ticket_price", ticket_price);
                        cmd.Parameters.AddWithValue("@tk_Train", tk_train);
                        cmd.Parameters.AddWithValue("@tk_Company", tk_company);
                        cmd.Parameters.AddWithValue("@tk_Passenger", tk_passenger);

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
