using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace database1
{
    public partial class company_revenue : Form
    {
        public company_revenue()
        {
            InitializeComponent();
        }

        private void return_btn12_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void display_btn5_Click(object sender, EventArgs e)
        {
            try
            {
                int c_id = Int32.Parse(search_cid_textbox.Text);
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                string query = "SELECT TC.COMPANY_NAME, COUNT(*) AS NUMBER_OF_TICKETS_SOLD, SUM(T.PRICE) AS TOTAL_REVENUE " +
                       "FROM TICKETING T " +
                       "INNER JOIN TRAIN_COMPANY TC ON T.COMPANY_ID = TC.COMPANY_ID " +
                       "WHERE T.COMPANY_ID = @CompanyID " +
                       "GROUP BY TC.COMPANY_NAME";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CompanyID", c_id); // Corrected parameter name
                    conn.Open();

                    revenue_data.Rows.Clear();
                    revenue_data.Columns.Clear();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {




                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No records found.");
                        }
                        else

                        {
                            revenue_data.Columns.Add("COMPANY_NAME", "Company Name");
                            revenue_data.Columns.Add("NUMBER_OF_TICKETS_SOLD", "Number of Tickets Sold");
                            revenue_data.Columns.Add("TOTAL_REVENUE", "Total Revenue");

                            while (reader.Read()) { 

                            string companyName = reader.GetString(0);
                            int numberOfTicketsSold = reader.GetInt32(1); // Assuming NUMBER_OF_TICKETS_SOLD is the second column
                            int totalRevenue = reader.GetInt32(2); // Assuming TOTAL_REVENUE is the third column

                            revenue_data.Rows.Add(companyName, numberOfTicketsSold, totalRevenue);
                        }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
