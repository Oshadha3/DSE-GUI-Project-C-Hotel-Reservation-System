using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       public void loadForm(Object Form) 
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag= f;
            f.Show();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbGuests(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new frmGuest());
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            loadForm(new frmRoom());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin secondForm = new frmLogin();
            secondForm.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            loadForm(new frmReservation());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadForm(new frmHome());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            loadForm(new frmSetting());
        }
    }
}
