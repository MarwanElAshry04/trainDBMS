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
    public partial class delete_ticket : Form
    {
        public delete_ticket()
        {
            InitializeComponent();
        }

        private void return_btn16_Click(object sender, EventArgs e)
        {
            mainpage2 mp2 = new mainpage2();
            mp2.Show();
            this.Hide();
        }

        private void update_btn1_Click(object sender, EventArgs e)
        {

            try
            {
                int passenger_id_delete = Int32.Parse(p_delete_textbox.Text);
                string deleteQuery = "DELETE FROM TICKETING WHERE PASSENGER_ID = @PassengerID";

                using (SqlConnection conn = new SqlConnection(@"Data Source=MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog=final submission;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@PassengerID", passenger_id_delete);
                        int rowsDeleted = deleteCmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsDeleted} ticket(s) deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    

        int new_ticket = Int32.Parse(new_tnum_textbox.Text);
            DateTime new_pdate = new_pdate_datetime.Value;
            int new_price = Int32.Parse(new_tprice_textbox.Text);
            int new_train = Int32.Parse(new_trnum_textbox.Text);
            int new_cid = Int32.Parse(new_cid_textbox.Text);
            int new_passenger = Int32.Parse(new_pid_textbox.Text);

            string updateQuery = "INSERT INTO TICKETING (TICKET_NUMBER, PURCHASE_DATE, PRICE, TRAIN_NUMBER, COMPANY_ID, PASSENGER_ID) VALUES (@TicketNumber, @PurchaseDate, @Price, @TrainNumber, @CompanyId, @PassengerId)";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = MARWAN-LAPTOP\SQLEXPRESS;Initial Catalog = final submission;Integrated Security = True");
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@TicketNumber", new_ticket);
                    cmd.Parameters.AddWithValue("@PurchaseDate", new_pdate);
                    cmd.Parameters.AddWithValue("@Price", new_price);
                    cmd.Parameters.AddWithValue("@TrainNumber", new_train);
                    cmd.Parameters.AddWithValue("@CompanyId", new_cid);
                    cmd.Parameters.AddWithValue("@PassengerId", new_passenger);

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
            }

                     
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
