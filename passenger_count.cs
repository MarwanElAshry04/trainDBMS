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
    public partial class passenger_count : Form
    {
        public passenger_count()
        {
            InitializeComponent();
        }

        private void return_btn14_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void Display_btn7_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                string query = "SELECT TRAIN_NUMBER, COUNT(*) AS TOTAL_PASSENGERS FROM TICKETING GROUP BY TRAIN_NUMBER";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        passenger_data.Columns.Add("TRAIN_NUMBER", "Train Number");
                        passenger_data.Columns.Add("TOTAL_PASSENGERS", "Total Passengers");

                        passenger_data.Rows.Clear();

                        while (reader.Read())
                        {


                            int trainNumber = reader.GetInt32(0);
                            int totalPassengers = reader.GetInt32(1);

                            passenger_data.Rows.Add(trainNumber, totalPassengers);
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

