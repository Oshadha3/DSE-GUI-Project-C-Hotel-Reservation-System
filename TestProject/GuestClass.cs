using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace TestProject
{
    internal class GuestClass
    {
        private int guest_id;
        private string guest_name;
        private string guest_NIC;
        private string guest_email;
        private string guest_phone;
        private string guest_address;

        public GuestClass()
        {
            guest_id = 0;
            guest_name = string.Empty;
            guest_NIC = string.Empty;
            guest_email = string.Empty;
            guest_phone = string.Empty;
            guest_address = string.Empty;
        }

        public int Guest_id { get => guest_id; set => guest_id = value; }
        public string Guest_name { get => guest_name; set => guest_name = value; }
        public string Guest_NIC { get => guest_NIC; set => guest_NIC = value; }
        public string Guest_email { get => guest_email; set => guest_email = value; }
        public string Guest_phone { get => guest_phone; set => guest_phone = value; }
        public string Guest_address { get => guest_address; set => guest_address = value; }


        public void guest_insert_query()
        {
            
            try
            {

                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "INSERT INTO guest (guest_name, guest_NIC, guest_email, guest_phone, guest_address) VALUES (@guest_name, @guest_NIC, @guest_email, @guest_phone, @guest_address)";
                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@guest_name", guest_name );
                cmd.Parameters.AddWithValue("@guest_NIC", guest_NIC);
                cmd.Parameters.AddWithValue("@guest_email", guest_email);
                cmd.Parameters.AddWithValue("@guest_phone", guest_phone);
                cmd.Parameters.AddWithValue("@guest_address", guest_address);
                cmd.ExecuteNonQuery();
                conr.Close();
                MessageBox.Show("Successfully Added...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable SearchGuest(string searchCriteria)
        {
           try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "SELECT * FROM guest WHERE guest_name LIKE @searchCriteria OR guest_NIC LIKE @searchCriteria OR guest_email LIKE @searchCriteria OR guest_phone LIKE @searchCriteria OR guest_address LIKE @searchCriteria";
                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%");

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

        public void guest_update_query(string newGuestName, string newGuestNIC, string newGuestEmail, string newGuestPhone, string newGuestAddress)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();

                string query = "UPDATE guest SET guest_name = @newGuestName, guest_email = @newGuestEmail, guest_phone = @newGuestPhone, guest_address = @newGuestAddress WHERE guest_NIC = @newGuestNIC";

                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@newGuestName", newGuestName);
                cmd.Parameters.AddWithValue("@newGuestNIC", newGuestNIC);
                cmd.Parameters.AddWithValue("@newGuestEmail", newGuestEmail);
                cmd.Parameters.AddWithValue("@newGuestPhone", newGuestPhone);
                cmd.Parameters.AddWithValue("@newGuestAddress", newGuestAddress);

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Guest information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No records updated. Guest not found or no changes made.");
                }

                conr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchGuest2(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();

                conr.Open();

                    string query = "SELECT  guest_name, guest_email, guest_phone, guest_address FROM guest WHERE guest_NIC LIKE @searchCriteria";
                    using (MySqlCommand cmd = new MySqlCommand(query, conr))
                    {
                    cmd.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                             guest_name = reader["guest_name"].ToString();
                             guest_email = reader["guest_email"].ToString();
                             guest_phone = reader["guest_phone"].ToString();
                             guest_address = reader["guest_address"].ToString();
                        }
                    }
                    }
                    conr.Close ();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void guest_delete_query(string searchCriteria) 
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string quary = " DELETE FROM guest WHERE guest_NIC = @guestNIC ";
                MySqlCommand cmd = new MySqlCommand(quary, conr);
                cmd.Parameters.AddWithValue("@guestNIC", searchCriteria);

                int rowsDeleted = cmd.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Guest information deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No records deleted. Guest not found .");
                }
                conr.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
