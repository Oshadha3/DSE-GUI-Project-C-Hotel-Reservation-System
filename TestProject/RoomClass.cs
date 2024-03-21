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
    internal class RoomClass
    {
        private int room_id;
        private string room_number;
        private string room_type;
        private string capacity;
        private string room_description;

        public RoomClass()
        {
            room_id = 0;
            room_number = string.Empty;
            capacity = string.Empty;
            room_type = string.Empty;
            room_description = string.Empty;
        }

        public int Room_id { get => room_id; set => room_id = value; }
        public string Room_number { get => room_number; set => room_number = value; }
        public string Room_type { get => room_type; set => room_type = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Room_description { get => room_description; set => room_description = value; }

        public void room_insert_query()
        {
            try
            {

                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "INSERT INTO room (room_number, room_type, capacity, room_description) VALUES (@room_number, @room_type, @capacity, @room_description)";
                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@room_number", room_number);
                cmd.Parameters.AddWithValue("@room_type", room_type);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                cmd.Parameters.AddWithValue("@room_description", room_description);
                cmd.ExecuteNonQuery();
                conr.Close();
                MessageBox.Show("Successfully Added...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable SearchRoom(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "SELECT * FROM room  WHERE room_number LIKE @searchCriteria OR room_type LIKE @searchCriteria OR capacity LIKE @searchCriteria OR room_description LIKE @searchCriteria ";
                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%");

                DataTable dt = new DataTable();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                conr.Close();

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void room_update_query(string newNumber, string newCapacity, string newDescription)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();

                string query = "UPDATE room SET room_type = @roomType, capacity = @roomCapacity, room_description = @roomDescription WHERE room_number = @roomNumber ";

                MySqlCommand cmd = new MySqlCommand(query, conr);
                cmd.Parameters.AddWithValue("@roomType", room_type);
                cmd.Parameters.AddWithValue("@roomCapacity", newCapacity);
                cmd.Parameters.AddWithValue("@roomDescription", newDescription);
                cmd.Parameters.AddWithValue("@roomNumber", newNumber);

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Room information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No records updated. Room not found or no changes made.");
                }

                conr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchRoom2(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();

                conr.Open();

                string query = "SELECT  room_type, capacity, room_description FROM room WHERE room_number LIKE @searchCriteria";
                using (MySqlCommand cmd = new MySqlCommand(query, conr))
                {
                    cmd.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //room_number = reader["room_number"].ToString();
                            room_type = reader["room_type"].ToString();
                            capacity = reader["capacity"].ToString();
                            room_description = reader["room_description"].ToString();
                        }
                    }
                }
                conr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void room_delete_query(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string quary = " DELETE FROM room WHERE room_number  = @number ";
                MySqlCommand cmd = new MySqlCommand(quary, conr);
                cmd.Parameters.AddWithValue("@number", searchCriteria);

                int rowsDeleted = cmd.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Room Information Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("No Records Deleted. Room Not Found .");
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
