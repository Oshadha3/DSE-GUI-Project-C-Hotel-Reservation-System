using Google.Protobuf.WellKnownTypes;
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
using System.Xml.Linq;

namespace TestProject
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            User user = new User();
            DataTable userData = user.SearchUser();
            UserGrid.DataSource = userData;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.user_update_query(txtUsernameSU.Text,txtPasswordSU.Text,txtPhoneNumberSU.Text,txtConfirmPasswordSU.Text);
            txtUsernameSU.Text = string.Empty;
            txtPhoneNumberSU.Text = string.Empty;
            txtPasswordSU.Text = string.Empty;
            txtConfirmPasswordSU.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.user_delete_query(txtUsernameSU.Text);
            txtUsernameSU.Text = string.Empty;
            txtPhoneNumberSU.Text = string.Empty;
            txtPasswordSU.Text = string.Empty;
            txtConfirmPasswordSU.Text = string.Empty;
        }

        private void txtUsernameSU_TextChanged(object sender, EventArgs e)
        {
            User user = new User();
            user.SearchUser2(txtUsernameSU.Text);
            txtPasswordSU.Text = user.Password;
            txtConfirmPasswordSU.Text = user.Confirm_password;
            txtPhoneNumberSU.Text = user.User_phonenumber;

        }

        private void btnSave_Click(object sender, EventArgs e)
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

                if (IsValidUsername(txtUsername.Text) && IsValidPassword(txtPassword.Text) && IsPasswordConfirmed(txtPassword.Text, txtConfirmPassword.Text))
                {

                    string userName = txtUsername.Text;
                    string phoneNumber = txtPhoneNumber.Text;
                    string password = txtPassword.Text;
                    string confirmPassworde = txtConfirmPassword.Text;

                    try
                    {

                        MySqlConnection conr = DBConnection.connectDB();
                        conr.Open();
                        string query = "INSERT INTO userdetails (Username, PhoneNumber, Password) VALUES (@Username, @PhoneNumber, @Password)";
                        MySqlCommand cmd = new MySqlCommand(query, conr);
                        cmd.Parameters.AddWithValue("@Username", userName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();
                        conr.Close();
                        MessageBox.Show("Successfully Registered...");
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtPhoneNumber.Text = string.Empty;
                        txtConfirmPassword.Text = string.Empty;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }
    }
}
