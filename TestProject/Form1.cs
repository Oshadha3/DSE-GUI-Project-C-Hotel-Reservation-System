using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister secondForm = new frmRegister();
            secondForm.Show();           
            this.Hide();
            MessageBox.Show("Welcome!\nYour Username MUST be 5 characters long.\nYour Password MUST be at least 8 characters long and include\none uppercase letter, one lowercase letter and one digit.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /*string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            bool IsValidUsername(string username)
            {
                bool isValid = false;

                try
                {
                    
                        MySqlConnection conr = DBConnection.connectDB();
                        conr.Open();
                        string query = "SELECT COUNT(*) FROM userdetails WHERE Username = @Username";
                        MySqlCommand cmd = new MySqlCommand(query, conr);
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            isValid = true;
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking the username: " + ex.Message);
                }

                return isValid;
            }

            bool ValidUsernameChecker = IsValidUsername(enteredUsername);

            if (ValidUsernameChecker)
            {
                try
                {

                    MySqlConnection conr = DBConnection.connectDB();
                    conr.Open();
                    string query = "SELECT Password FROM userdetails WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conr);
                    cmd.Parameters.AddWithValue("@Username", enteredUsername);
                    string storedPasswordHash = cmd.ExecuteScalar() as string;

                    bool VerifyPassword(string inputPassword, string storedHash)
                    {
                        return inputPassword == storedHash;
                    }

                    bool isPasswordValid = VerifyPassword(enteredPassword, storedPasswordHash);

                    if (isPasswordValid)
                    {
                        //MessageBox.Show("Successfully Login");
                        
                        this.Hide();
                        //Add next form
                        frmMain main = new frmMain();
                        main.Show();
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
            else
            {
                MessageBox.Show("Invalid username..." );
            }*/
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            bool IsValidUsername(string username)
            {
                bool isValid = false;

                try
                {

                    MySqlConnection conr = DBConnection.connectDB();
                    conr.Open();
                    string query = "SELECT COUNT(*) FROM userdetails WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conr);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        isValid = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking the username: " + ex.Message);
                }

                return isValid;
            }

            bool ValidUsernameChecker = IsValidUsername(enteredUsername);

            if (ValidUsernameChecker)
            {
                try
                {

                    MySqlConnection conr = DBConnection.connectDB();
                    conr.Open();
                    string query = "SELECT Password FROM userdetails WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conr);
                    cmd.Parameters.AddWithValue("@Username", enteredUsername);
                    string storedPasswordHash = cmd.ExecuteScalar() as string;

                    bool VerifyPassword(string inputPassword, string storedHash)
                    {
                        return inputPassword == storedHash;
                    }

                    bool isPasswordValid = VerifyPassword(enteredPassword, storedPasswordHash);

                    if (isPasswordValid)
                    {
                        //MessageBox.Show("Successfully Login");

                        this.Hide();
                        //Add next form
                        frmMain main = new frmMain();
                        main.Show();
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
            else
            {
                MessageBox.Show("Invalid username...");
            }
        }
    }
}
