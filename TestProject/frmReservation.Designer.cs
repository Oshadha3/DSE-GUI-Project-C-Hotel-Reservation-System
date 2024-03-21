namespace TestProject
{
    partial class frmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.reservationGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.OutDP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.InDP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRoomType = new System.Windows.Forms.GroupBox();
            this.rdbTwin = new System.Windows.Forms.RadioButton();
            this.rdbFamily = new System.Windows.Forms.RadioButton();
            this.rdbDouble = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGuestNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.gbRoomType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 755);
            this.tabControl1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.White;
            this.tab1.Controls.Add(this.btnCheck);
            this.tab1.Controls.Add(this.reservationGridView);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.ForeColor = System.Drawing.Color.Black;
            this.tab1.Location = new System.Drawing.Point(4, 54);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1086, 697);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Check Reservation";
            // 
            // btnCheck
            // 
            this.btnCheck.Animated = true;
            this.btnCheck.AutoRoundedCorners = true;
            this.btnCheck.BorderRadius = 21;
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FillColor = System.Drawing.Color.Crimson;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.IndicateFocus = true;
            this.btnCheck.Location = new System.Drawing.Point(382, 117);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(272, 45);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // reservationGridView
            // 
            this.reservationGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationGridView.Location = new System.Drawing.Point(26, 175);
            this.reservationGridView.Name = "reservationGridView";
            this.reservationGridView.RowHeadersWidth = 51;
            this.reservationGridView.RowTemplate.Height = 24;
            this.reservationGridView.Size = new System.Drawing.Size(1024, 483);
            this.reservationGridView.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(130, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserved Rooms List\r\n";
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.White;
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab2.Controls.Add(this.btnDelete);
            this.tab2.Controls.Add(this.OutDP);
            this.tab2.Controls.Add(this.btnClear);
            this.tab2.Controls.Add(this.btnSave);
            this.tab2.Controls.Add(this.InDP);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.gbRoomType);
            this.tab2.Controls.Add(this.txtRoomNumber);
            this.tab2.Controls.Add(this.label13);
            this.tab2.Controls.Add(this.label15);
            this.tab2.Controls.Add(this.txtGuestNIC);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.panel2);
            this.tab2.ForeColor = System.Drawing.Color.Black;
            this.tab2.Location = new System.Drawing.Point(4, 54);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1086, 697);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Add and Delete Reservation";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(616, 570);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 47);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OutDP
            // 
            this.OutDP.Animated = true;
            this.OutDP.AutoRoundedCorners = true;
            this.OutDP.BorderRadius = 18;
            this.OutDP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.OutDP.Checked = true;
            this.OutDP.FillColor = System.Drawing.Color.Black;
            this.OutDP.FocusedColor = System.Drawing.Color.Black;
            this.OutDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OutDP.ForeColor = System.Drawing.Color.White;
            this.OutDP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OutDP.IndicateFocus = true;
            this.OutDP.Location = new System.Drawing.Point(482, 459);
            this.OutDP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OutDP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OutDP.Name = "OutDP";
            this.OutDP.Size = new System.Drawing.Size(263, 39);
            this.OutDP.TabIndex = 45;
            this.OutDP.Value = new System.DateTime(2023, 10, 12, 10, 7, 33, 562);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(455, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 47);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(301, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 47);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InDP
            // 
            this.InDP.Animated = true;
            this.InDP.AutoRoundedCorners = true;
            this.InDP.BorderRadius = 18;
            this.InDP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.InDP.Checked = true;
            this.InDP.FillColor = System.Drawing.Color.Black;
            this.InDP.FocusedColor = System.Drawing.Color.Black;
            this.InDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InDP.ForeColor = System.Drawing.Color.White;
            this.InDP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.InDP.IndicateFocus = true;
            this.InDP.Location = new System.Drawing.Point(482, 397);
            this.InDP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.InDP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.InDP.Name = "InDP";
            this.InDP.Size = new System.Drawing.Size(263, 39);
            this.InDP.TabIndex = 41;
            this.InDP.Value = new System.DateTime(2023, 10, 12, 10, 7, 33, 562);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(185, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "Check-Out :-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(185, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "Check-In :-";
            // 
            // gbRoomType
            // 
            this.gbRoomType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbRoomType.Controls.Add(this.rdbTwin);
            this.gbRoomType.Controls.Add(this.rdbFamily);
            this.gbRoomType.Controls.Add(this.rdbDouble);
            this.gbRoomType.Controls.Add(this.rdbSingle);
            this.gbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRoomType.Location = new System.Drawing.Point(482, 302);
            this.gbRoomType.Name = "gbRoomType";
            this.gbRoomType.Size = new System.Drawing.Size(383, 70);
            this.gbRoomType.TabIndex = 38;
            this.gbRoomType.TabStop = false;
            // 
            // rdbTwin
            // 
            this.rdbTwin.AutoSize = true;
            this.rdbTwin.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTwin.Location = new System.Drawing.Point(301, 32);
            this.rdbTwin.Name = "rdbTwin";
            this.rdbTwin.Size = new System.Drawing.Size(72, 28);
            this.rdbTwin.TabIndex = 3;
            this.rdbTwin.TabStop = true;
            this.rdbTwin.Text = "Twin";
            this.rdbTwin.UseVisualStyleBackColor = true;
            // 
            // rdbFamily
            // 
            this.rdbFamily.AutoSize = true;
            this.rdbFamily.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFamily.Location = new System.Drawing.Point(199, 32);
            this.rdbFamily.Name = "rdbFamily";
            this.rdbFamily.Size = new System.Drawing.Size(87, 28);
            this.rdbFamily.TabIndex = 2;
            this.rdbFamily.TabStop = true;
            this.rdbFamily.Text = "Family";
            this.rdbFamily.UseVisualStyleBackColor = true;
            // 
            // rdbDouble
            // 
            this.rdbDouble.AutoSize = true;
            this.rdbDouble.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDouble.Location = new System.Drawing.Point(104, 32);
            this.rdbDouble.Name = "rdbDouble";
            this.rdbDouble.Size = new System.Drawing.Size(92, 28);
            this.rdbDouble.TabIndex = 1;
            this.rdbDouble.TabStop = true;
            this.rdbDouble.Text = "Double";
            this.rdbDouble.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingle.Location = new System.Drawing.Point(16, 32);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(83, 28);
            this.rdbSingle.TabIndex = 0;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(482, 236);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(383, 44);
            this.txtRoomNumber.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(185, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 32);
            this.label13.TabIndex = 36;
            this.label13.Text = "Room Number :-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(185, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 32);
            this.label15.TabIndex = 35;
            this.label15.Text = "Room Type :-";
            // 
            // txtGuestNIC
            // 
            this.txtGuestNIC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGuestNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestNIC.Location = new System.Drawing.Point(482, 170);
            this.txtGuestNIC.Multiline = true;
            this.txtGuestNIC.Name = "txtGuestNIC";
            this.txtGuestNIC.Size = new System.Drawing.Size(383, 44);
            this.txtGuestNIC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(185, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Guest NIC :-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(345, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 59);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add Reservation";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 755);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservation";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.gbRoomType.ResumeLayout(false);
            this.gbRoomType.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reservationGridView;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbRoomType;
        private System.Windows.Forms.RadioButton rdbTwin;
        private System.Windows.Forms.RadioButton rdbFamily;
        private System.Windows.Forms.RadioButton rdbDouble;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGuestNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker InDP;
        private Guna.UI2.WinForms.Guna2DateTimePicker OutDP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}