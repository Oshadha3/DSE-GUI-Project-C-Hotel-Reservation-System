using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    internal class ReservationClass
    {
        private int reservation_id;
        private DateTime check_in_date;
        private DateTime check_out_date;

        public ReservationClass()
        {
            reservation_id = 0;
            check_in_date = DateTime.MinValue;
            check_out_date = DateTime.MinValue;
        }

        public int Reservation_id { get => reservation_id; set => reservation_id = value; }
        public DateTime Check_in_date { get => check_in_date; set => check_in_date = value; }
        public DateTime Check_out_date { get => check_out_date; set => check_out_date = value; }

        public void reservation_insert_query(string guest_NIC, string room_Number, DateTime check_in, DateTime check_out, string room_type)
        {

            try
            {

                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "INSERT INTO reservation (guest_NIC, room_Number, check_in, check_out, room_type) VALUES (@guest_NIC, @room_Number, @check_in, @check_out, @room_type)";
                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@guest_NIC", guest_NIC);
                cmd.Parameters.AddWithValue("@room_Number", room_Number);
                cmd.Parameters.AddWithValue("@check_in", check_in);
                cmd.Parameters.AddWithValue("@check_out", check_out);
                cmd.Parameters.AddWithValue("@room_type", room_type);
                cmd.ExecuteNonQuery();
                conr.Close();
                MessageBox.Show("Successfully Added...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable SearchReservation()
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "SELECT * FROM reservation";
                MySqlCommand cmd = new MySqlCommand(query, conr);

                DataTable dt = new DataTable();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void reservation_delete_query(string searchCriteria1, string searchCriteria2)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string quary = " DELETE FROM reservation WHERE room_number = @roomnumber AND guest_NIC = @guest_NIC ";
                MySqlCommand cmd = new MySqlCommand(quary, conr);
                cmd.Parameters.AddWithValue("@roomnumber", searchCriteria1);
                cmd.Parameters.AddWithValue("@guest_NIC", searchCriteria2);

                int rowsDeleted = cmd.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Reservation information deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No records deleted. Reservation not found .");
                }
                conr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
