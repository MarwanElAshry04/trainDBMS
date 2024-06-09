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
    public partial class no_depart : Form
    {
        public no_depart()
        {
            InitializeComponent();
        }

        private void return_btn16_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void Display_btn10_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True";
                string query = "SELECT STATION_ID, STATION_NAME, LOCATION FROM STATION S WHERE NOT EXISTS (SELECT * FROM TRAIN T  WHERE S.STATION_ID = T.STATION_ID_DEPART)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        stations_data.Columns.Add("STATION_ID", "Station ID");
                        stations_data.Columns.Add("STATION_NAME", "Station Name");
                        stations_data.Columns.Add("LOCATION", "Location");

                        stations_data.Rows.Clear();

                        while (reader.Read())
                        {
                            string stationID = reader.GetString(0);
                            string stationName = reader.GetString(1);
                            string Location = reader.GetString(2);

                            stations_data.Rows.Add(stationID, stationName, Location);
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
