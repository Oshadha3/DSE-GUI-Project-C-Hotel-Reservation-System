using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestProject
{
    public partial class frmGuest : Form
    {
        public frmGuest()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGuestName.Text) || string.IsNullOrEmpty(txtGuestNIC.Text) || string.IsNullOrEmpty(txtGuestPhoneNo.Text) || string.IsNullOrEmpty(txtGuestEmail.Text) || string.IsNullOrEmpty(txtGuestAddress.Text))
            {
                MessageBox.Show("Text boxes can not be empty !!!");
            }
            else
            {
                GuestClass guestClass = new GuestClass();
                guestClass.Guest_NIC = txtGuestNIC.Text;          
                guestClass.Guest_email = txtGuestEmail.Text;
                guestClass.Guest_address = txtGuestAddress.Text;
                guestClass.Guest_phone = txtGuestPhoneNo.Text;
                guestClass.Guest_name = txtGuestName.Text;

                guestClass.guest_insert_query();

                txtGuestNIC.Text = string.Empty;
                txtGuestEmail.Text = string.Empty;
                txtGuestAddress.Text = string.Empty;
                txtGuestPhoneNo.Text = string.Empty;
                txtGuestName.Text = string.Empty;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestNIC.Text = string.Empty;
            txtGuestEmail.Text = string.Empty;
            txtGuestAddress.Text = string.Empty;
            txtGuestPhoneNo.Text = string.Empty;
            txtGuestName.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = txtSearch.Text;
            GuestClass guestClass = new GuestClass();
            DataTable guestData = guestClass.SearchGuest(searchCriteria);
            GuestGridView.DataSource = guestData;
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            GuestClass guestClass = new GuestClass();
            guestClass.SearchGuest2(txtNIC.Text);
            txtEmail.Text = guestClass.Guest_email;
            txtAddress.Text = guestClass.Guest_address;
            txtPhoneNo.Text = guestClass.Guest_phone;
            txtName.Text = guestClass.Guest_name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GuestClass guestClass = new GuestClass();
            guestClass.guest_update_query(txtName.Text, txtNIC.Text, txtEmail.Text, txtPhoneNo.Text, txtAddress.Text);
            txtName.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GuestClass guestClass = new GuestClass();
            guestClass.guest_delete_query(txtNIC.Text);
            txtName.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
