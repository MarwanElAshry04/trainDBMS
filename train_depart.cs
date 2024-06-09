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
    public partial class train_depart : Form
    {
        public train_depart()
        {
            InitializeComponent();
        }

        private void Return_btn9_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void Display_btn1_Click(object sender, EventArgs e)
        {
            try
            {


                string stationId = station_id_textbox2.Text.Trim();
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                string query = "SELECT TRAIN_NUMBER FROM TRAIN WHERE STATION_ID_DEPART = @StationId";

                Trains.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@StationId", stationId);

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int trainNumber = reader.GetInt32(reader.GetOrdinal("TRAIN_NUMBER"));
                                Trains.Items.Add(trainNumber);
                            }
                        }
                        else
                        {
                            Trains.Items.Add("No trains found departing from station " + stationId);
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
    

