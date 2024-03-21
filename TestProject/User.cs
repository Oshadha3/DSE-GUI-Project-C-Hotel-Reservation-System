using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestProject
{
    internal class User
    {
        string user_name;
        string user_phonenumber;
        string password;
        string confirm_password;

        public User()
        {
            user_name = string.Empty;
            user_phonenumber = string.Empty;
            password = string.Empty;
            confirm_password = string.Empty;       
        }

        public string User_name { get => user_name; set => user_name = value; }
        public string User_phonenumber { get => user_phonenumber; set => user_phonenumber = value; }
        public string Password { get => password; set => password = value; }
        public string Confirm_password { get => confirm_password; set => confirm_password = value; }

        public DataTable SearchUser()
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string query = "SELECT * FROM userdetails";
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

        public void user_update_query(string Username, string Password, string PhoneNumber, string ConfirmPassword)
        {
            try
            {

                bool IsValidUsername(string username)
                {
                    return !string.IsNullOrEmpty(username) && username.Length >= 5;
                }

                bool IsValidPassword(string passworde)
                {
                    return !string.IsNullOrEmpty(passworde) &&
                           passworde.Length >= 8 &&
                           passworde.Any(char.IsUpper) &&
                           passworde.Any(char.IsLower) &&
                           passworde.Any(char.IsDigit);
                }

                bool IsPasswordConfirmed(string passworde, string confirmPassword)
                {
                    return passworde == confirmPassword;
                }

                if (IsValidUsername(Username) && IsValidPassword(Password) && IsPasswordConfirmed(Password, ConfirmPassword))
                {

                    string userName = Username;
                    string phoneNumber = PhoneNumber;
                    string password = Password;
                    string confirmPassworde = ConfirmPassword;

                    try
                    {
                        MySqlConnection conr = DBConnection.connectDB();
                        conr.Open();

                        string query = "UPDATE userdetails SET PhoneNumber = @PhoneNumber, Password = @Password WHERE Username  = @Username ";

                        MySqlCommand cmd = new MySqlCommand(query, conr);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Username", Username);

                        int rowsUpdated = cmd.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("User information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records updated. User not found or no changes made.");
                        }

                        conr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void user_delete_query(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();
                conr.Open();
                string quary = " DELETE FROM userdetails WHERE Username  = @Username ";
                MySqlCommand cmd = new MySqlCommand(quary, conr);
                cmd.Parameters.AddWithValue("@Username", searchCriteria);

                int rowsDeleted = cmd.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No records deleted. User not found .");
                }
                conr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchUser2(string searchCriteria)
        {
            try
            {
                MySqlConnection conr = DBConnection.connectDB();

                conr.Open();

                string query = "SELECT PhoneNumber, Password FROM userdetails WHERE Username LIKE @searchCriteria";
                using (MySqlCommand cmd = new MySqlCommand(query, conr))
                {
                    cmd.Parameters.AddWithValue("@searchCriteria", "%" + searchCriteria + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_phonenumber = reader["PhoneNumber"].ToString();
                            password = reader["Password"].ToString();
                            confirm_password = reader["Password"].ToString();
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
    }
}



