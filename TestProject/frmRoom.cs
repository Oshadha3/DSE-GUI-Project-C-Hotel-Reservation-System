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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TestProject
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void rdbLuxery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!rdbDouble.Checked && !rdbFamily.Checked && !rdbSingle.Checked && !rdbTwin.Checked)
            {
                MessageBox.Show("Plese select room type...");
            }
            else if(string.IsNullOrEmpty(txtRoomNumber.Text) || string.IsNullOrEmpty(txtRoomCapacity.Text) || string.IsNullOrEmpty(txtRoomDescription.Text))
            {
                MessageBox.Show("Text boxes can not be empty !!!");
            }
            else
            {
                RoomClass roomClass = new RoomClass();
                roomClass.Room_number = txtRoomNumber.Text;
                roomClass.Capacity = txtRoomCapacity.Text;
                roomClass.Room_description = txtRoomDescription.Text;
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
                roomClass.room_insert_query();
                txtRoomNumber.Text = string.Empty;
                txtRoomDescription.Text = string.Empty;
                txtRoomCapacity.Text = string.Empty;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                RoomClass RoomClass = new RoomClass();
                RoomClass.room_delete_query(txtNewNumber.Text);
                 txtNewNumber.Text = string.Empty;
                 
                 txtNewCapacity.Text = string.Empty;
                 txtNewDescription.Text = string.Empty;
                 
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Text = string.Empty;
            txtRoomDescription.Text = string.Empty;
            txtRoomCapacity.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RoomClass roomClass = new RoomClass();
            DataTable roomData = roomClass.SearchRoom(txtSearch.Text);
            RoomGridView.DataSource = roomData;
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void txtNewNumber_TextChanged(object sender, EventArgs e)
        {
            RoomClass roomClass = new RoomClass();
            roomClass.SearchRoom2(txtNewNumber.Text);
            txtNewCapacity.Text = roomClass.Capacity;
            txtNewDescription.Text = roomClass.Room_description;

            if(roomClass.Room_type== "Family")
            {
                rdbFamilyU.Checked = true;
            }
            else if(roomClass.Room_type == "Single")
            {
                rdbSingleU.Checked = true;
            }
            else if(roomClass.Room_type == "Double")
            {
                rdbDoubleU.Checked = true;
            }
            else if( roomClass.Room_type == "Twin")
            { 
                rdbTwinU.Checked = true;           
            }
                else
                    {

                    }

          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RoomClass roomClass = new RoomClass();


            if (rdbFamilyU.Checked)
            {
                roomClass.Room_type = "Family";
            }
            else if (rdbSingleU.Checked)
            {
                roomClass.Room_type = "Single";
            }
            else if (rdbDoubleU.Checked)
            {
                roomClass.Room_type = "Double";
            }
            else if (rdbTwinU.Checked)
            {
                roomClass.Room_type = "Twin";
            }
            else
            {

            }
            roomClass.room_update_query(txtNewNumber.Text , txtNewCapacity.Text, txtNewDescription.Text);
            txtNewNumber.Text = string.Empty;
            txtNewCapacity.Text = string.Empty;
            txtNewDescription.Text = string.Empty;
           
        }

    }
}
