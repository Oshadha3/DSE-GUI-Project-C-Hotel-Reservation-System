using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestProject
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin secondForm = new frmLogin();
            secondForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtUsernameSU_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsernameSU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_2(object sender, EventArgs e)
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

                if (IsValidUsername(txtUsernameSU.Text) && IsValidPassword(txtPasswordSU.Text) && IsPasswordConfirmed(txtPasswordSU.Text, txtConfirmPasswordSU.Text))
                {

                    string userName = txtUsernameSU.Text;
                    string phoneNumber = txtPhoneNumberSU.Text;
                    string password = txtPasswordSU.Text;
                    string confirmPassworde = txtConfirmPasswordSU.Text;

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
                        txtUsernameSU.Text = string.Empty;
                        txtPasswordSU.Text = string.Empty;
                        txtPhoneNumberSU.Text = string.Empty;
                        txtConfirmPasswordSU.Text = string.Empty;
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
    }
}
