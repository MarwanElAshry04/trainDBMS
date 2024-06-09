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
    public partial class mainpage2 : Form
    {
        public mainpage2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");

        private void connect_mainbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connected successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
        }

        
    }

        private void train_company_btn_Click(object sender, EventArgs e)
        {
            TrainCompany t_company = new TrainCompany();
            t_company.Show();
            this.Hide();
        }

        private void station_main_btn_Click(object sender, EventArgs e)
        {
            station Station = new station();
            Station.Show();
            this.Hide();
        }

        private void train_driver_mainbtn_Click(object sender, EventArgs e)
        {
            traindriver t_driver = new traindriver();
            t_driver.Show();
            this.Hide();
        }

        private void train_mainbtn_Click(object sender, EventArgs e)
        {
            train Train = new train();
            Train.Show();
            this.Hide();
        }

        private void passenger_mainbtn_Click(object sender, EventArgs e)
        {
            passenger psgr = new passenger();
            psgr.Show();
            this.Hide();
        }

        private void mainpage2_Load(object sender, EventArgs e)
        {

        }

        private void ticketing_mainbtn_Click(object sender, EventArgs e)
        {
            ticketing2 ticket = new ticketing2();
            ticket.Show();
            this.Hide();
        }

        private void drives_mainbtn_Click(object sender, EventArgs e)
        {
            drives drive = new drives();
            drive.Show();
            this.Hide();
        }

        private void train_depart_mainbtn_Click(object sender, EventArgs e)
        {
            train_depart departure = new train_depart();
            departure.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            price_data prices = new price_data();
            prices.Show();
            this.Hide();
        }

        private void c_revenue_mainbtn_Click(object sender, EventArgs e)
        {
            company_revenue c_revenue = new company_revenue();
            c_revenue.Show();
            this.Hide();
        }

        private void t_companies_mainbtn_Click(object sender, EventArgs e)
        {
            train_companies t_companies = new train_companies();
            t_companies.Show();
            this.Hide();
        }

        private void p_count_mainbtn_Click(object sender, EventArgs e)
        {
            passenger_count p_count = new passenger_count();
            p_count.Show();
            this.Hide();
        }

        private void no_depart_mainbtn_Click(object sender, EventArgs e)
        {
            no_depart notExist = new no_depart();
            notExist.Show();
            this.Hide();
        }

        private void delete_insert_mainbtn_Click(object sender, EventArgs e)
        {
            delete_ticket updateTicket = new delete_ticket();
            updateTicket.Show();
            this.Hide();
        }
    }
}
