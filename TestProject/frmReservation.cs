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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!rdbDouble.Checked && !rdbFamily.Checked && !rdbSingle.Checked && !rdbTwin.Checked)
            {
                MessageBox.Show("Plese select room type...");
            }
            else if (string.IsNullOrEmpty(txtGuestNIC.Text) || string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                MessageBox.Show("Text boxes can not be empty !!!");
            }
            else
            {
                RoomClass roomClass = new RoomClass();
                roomClass.Room_number = txtRoomNumber.Text;

                if (rdbFamily.Checked)
                {
                    roomClass.Room_type = "Family";
                }
                else if (rdbSingle.Checked)
                {
                    roomClass.Room_type = "Single";
                }
                else if (rdbDouble.Checked)
                {
                    roomClass.Room_type = "Double";
                }
                else if (rdbTwin.Checked)
                {
                    roomClass.Room_type = "Twin";
                }
                else
                {

                }
                ReservationClass reservationClass = new ReservationClass();
                reservationClass.reservation_insert_query(txtGuestNIC.Text, txtRoomNumber.Text, InDP.Value, OutDP.Value, roomClass.Room_type);
                

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestNIC.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ReservationClass reservationClass = new ReservationClass();
            DataTable reservationData = reservationClass.SearchReservation();
            reservationGridView.DataSource = reservationData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ReservationClass reservationClass = new ReservationClass();
            reservationClass.reservation_delete_query(txtRoomNumber.Text, txtGuestNIC.Text);
        }
    }
}
