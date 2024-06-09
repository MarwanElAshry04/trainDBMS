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
    public partial class price_data : Form
    {
        public price_data()
        {
            InitializeComponent();
        }

        private void return_btn10_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void display_btn2_Click(object sender, EventArgs e)
        {
            try
            {
                int train_number = Int32.Parse(train_num_price_textbox.Text);
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                string query = "SELECT MAX(PRICE) AS MAX_PRICE, MIN(PRICE) AS MIN_PRICE FROM TICKETING WHERE TRAIN_NUMBER = @Train_number ";

                Minimum_Ticket_Price.Items.Clear();
                Maximum_Ticket_Price.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Train_number", train_number);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                         
                                int maxPrice = reader.GetInt32(reader.GetOrdinal("MAX_PRICE"));
                                int minPrice = reader.GetInt32(reader.GetOrdinal("MIN_PRICE"));
                                Minimum_Ticket_Price.Items.Add($"Min Price: {minPrice}");
                                Maximum_Ticket_Price.Items.Add($"Max Price: {maxPrice}");
                        }
                        else
                        {

                            Minimum_Ticket_Price.Items.Add("No data found for the specified train number.");
                            Maximum_Ticket_Price.Items.Add("No data found for the specified train number.");

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
