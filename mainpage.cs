//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace database1
//{
//    public partial class mainpage : Form
//    {
//        private string connetionString;

//        public mainpage()
//        {
//            InitializeComponent();

//        }
//        private void connectbtn_Click(object sender, EventArgs e)
//        {
           
//        }

//        //private void submitbtn_Click(object sender, EventArgs e)
//        //{
//        //    string eid = Station_ID_Box.Text;

//        //    string query = @"SELECT COUNT(*) AS NUMBER_OF_TRAINS
//        //                   FROM TRAIN
//        //                   WHERE STATION_ID_DEPART = @id;";
//        //    try
//        //    {
//        //        using (SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final train data;Integrated Security = True"))
//        //        {
//        //            conn.Open();
//        //            using (SqlCommand cmd = new SqlCommand(query, conn))
//        //            {
//        //                cmd.Parameters.AddWithValue("@id", eid);
//        //                int exe = cmd.ExecuteNonQuery();

//        //                using (SqlDataReader red = cmd.ExecuteReader())
//        //                {
//        //                    if (red.Read())
//        //                    {
//        //                        string nof = red["NUMBER_OF_TRAINS"].ToString();

//        //                        TrainLbox.Items.Clear();
//        //                        TrainLbox.Items.Add(nof);
//        //                    }
//        //                }

//        //            }
//        //            conn.Close();
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //    }
//        //}

//        private void Station_ID_Box_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void returnbtn_Click(object sender, EventArgs e)
//        {
            
//        }

//        private void tcompanybutton_Click(object sender, EventArgs e)
//        {
//            TrainCompany tc = new TrainCompany();
//            tc.Show();
//            this.Hide();
//        }

//        private void stationinsert_Click(object sender, EventArgs e)
//        {
//            station st = new station();
//            st.Show();
//            this.Hide();      
//        }

//        private void train_driver_Click(object sender, EventArgs e)
//        {
//            traindriver dr = new traindriver();
//            dr.Show();
//            this.Hide();
//        }

//        private void train_btn_Click(object sender, EventArgs e)
//        {
//            train tr = new train();
//            tr.Show();
//            this.Hide();
//        }

//        private void passenger_btn_Click(object sender, EventArgs e)
//        {
//            passenger pr = new passenger();
//            pr.Show();
//            this.Hide();
//        }

       

//        private void drives_btn_Click(object sender, EventArgs e)
//        {
//            drives mtom = new drives();
//            mtom.Show();
//            this.Hide();
//        }

//        private void ticket_btn4_Click(object sender, EventArgs e)
//        {
//            ticketing2 ticket = new ticketing2();
//            ticket.Show();
//            this.Hide();
//        }

//        private void train_depart_btn_Click(object sender, EventArgs e)
//        {
//            train_depart train_station = new train_depart();
//            train_station.Show();
//            this.Hide();
//        }

//        private void price_databtn_Click(object sender, EventArgs e)
//        {
//            price_data price_Data = new price_data();
//            price_Data.Show();
//            this.Hide();
//        }

//        private void companies_btn_Click(object sender, EventArgs e)
//        {
//            train_companies train_Companies = new train_companies();
//            train_Companies.Show();
//            this.Hide();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            company_revenue company_Revenue = new company_revenue();
//            company_Revenue.Show();
//            this.Hide();
//        }

//        private void mainpage_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}


