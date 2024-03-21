namespace TestProject
{
    partial class frmRoom
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
            this.txtRoomDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRoomType = new System.Windows.Forms.GroupBox();
            this.rdbTwin = new System.Windows.Forms.RadioButton();
            this.rdbFamily = new System.Windows.Forms.RadioButton();
            this.rdbDouble = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.txtNewCapacity = new System.Windows.Forms.TextBox();
            this.txtNewDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbNewType = new System.Windows.Forms.GroupBox();
            this.rdbTwinU = new System.Windows.Forms.RadioButton();
            this.rdbFamilyU = new System.Windows.Forms.RadioButton();
            this.rdbDoubleU = new System.Windows.Forms.RadioButton();
            this.rdbSingleU = new System.Windows.Forms.RadioButton();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.gbRoomType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.gbNewType.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
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
            this.tab1.Controls.Add(this.txtRoomDescription);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.gbRoomType);
            this.tab1.Controls.Add(this.btnClear);
            this.tab1.Controls.Add(this.btnSave);
            this.tab1.Controls.Add(this.txtRoomCapacity);
            this.tab1.Controls.Add(this.txtRoomNumber);
            this.tab1.Controls.Add(this.label12);
            this.tab1.Controls.Add(this.label13);
            this.tab1.Controls.Add(this.label14);
            this.tab1.Controls.Add(this.label15);
            this.tab1.Controls.Add(this.panel1);
            this.tab1.ForeColor = System.Drawing.Color.Black;
            this.tab1.Location = new System.Drawing.Point(4, 54);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1086, 697);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Add Room";
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // txtRoomDescription
            // 
            this.txtRoomDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomDescription.Location = new System.Drawing.Point(422, 340);
            this.txtRoomDescription.Multiline = true;
            this.txtRoomDescription.Name = "txtRoomDescription";
            this.txtRoomDescription.Size = new System.Drawing.Size(386, 178);
            this.txtRoomDescription.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(92, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Room Description :-";
            // 
            // gbRoomType
            // 
            this.gbRoomType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbRoomType.Controls.Add(this.rdbTwin);
            this.gbRoomType.Controls.Add(this.rdbFamily);
            this.gbRoomType.Controls.Add(this.rdbDouble);
            this.gbRoomType.Controls.Add(this.rdbSingle);
            this.gbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRoomType.Location = new System.Drawing.Point(422, 214);
            this.gbRoomType.Name = "gbRoomType";
            this.gbRoomType.Size = new System.Drawing.Size(386, 70);
            this.gbRoomType.TabIndex = 34;
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
            this.rdbTwin.CheckedChanged += new System.EventHandler(this.rdbLuxery_CheckedChanged);
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(641, 579);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 47);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(430, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 47);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCapacity.Location = new System.Drawing.Point(422, 290);
            this.txtRoomCapacity.Multiline = true;
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(386, 44);
            this.txtRoomCapacity.TabIndex = 31;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(422, 164);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(386, 44);
            this.txtRoomNumber.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(92, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "Room Capacity :-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(92, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 32);
            this.label13.TabIndex = 22;
            this.label13.Text = "Room Number :-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(147, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 39);
            this.label14.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(92, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 32);
            this.label15.TabIndex = 20;
            this.label15.Text = "Room Type :-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room";
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.White;
            this.tab2.Controls.Add(this.btnSearchClear);
            this.tab2.Controls.Add(this.RoomGridView);
            this.tab2.Controls.Add(this.txtSearch);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.panel2);
            this.tab2.ForeColor = System.Drawing.Color.Black;
            this.tab2.Location = new System.Drawing.Point(4, 54);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1086, 697);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Search Room";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(766, 151);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(58, 44);
            this.btnSearchClear.TabIndex = 17;
            this.btnSearchClear.Text = "X";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // RoomGridView
            // 
            this.RoomGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Location = new System.Drawing.Point(36, 256);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersWidth = 51;
            this.RoomGridView.RowTemplate.Height = 24;
            this.RoomGridView.Size = new System.Drawing.Size(1003, 402);
            this.RoomGridView.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(280, 151);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(491, 44);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(116, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 44);
            this.label9.TabIndex = 14;
            this.label9.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(351, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 59);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search Room";
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.White;
            this.tab3.Controls.Add(this.txtNewCapacity);
            this.tab3.Controls.Add(this.txtNewDescription);
            this.tab3.Controls.Add(this.label2);
            this.tab3.Controls.Add(this.gbNewType);
            this.tab3.Controls.Add(this.txtCapacity);
            this.tab3.Controls.Add(this.txtNewNumber);
            this.tab3.Controls.Add(this.label3);
            this.tab3.Controls.Add(this.label4);
            this.tab3.Controls.Add(this.label6);
            this.tab3.Controls.Add(this.btnDelete);
            this.tab3.Controls.Add(this.btnUpdate);
            this.tab3.Controls.Add(this.panel3);
            this.tab3.ForeColor = System.Drawing.Color.Black;
            this.tab3.Location = new System.Drawing.Point(4, 54);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1086, 697);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Upadate & Delete Room";
            // 
            // txtNewCapacity
            // 
            this.txtNewCapacity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCapacity.Location = new System.Drawing.Point(463, 297);
            this.txtNewCapacity.Multiline = true;
            this.txtNewCapacity.Name = "txtNewCapacity";
            this.txtNewCapacity.Size = new System.Drawing.Size(386, 44);
            this.txtNewCapacity.TabIndex = 48;
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewDescription.Location = new System.Drawing.Point(463, 345);
            this.txtNewDescription.Multiline = true;
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new System.Drawing.Size(386, 178);
            this.txtNewDescription.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(133, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Room Description :-";
            // 
            // gbNewType
            // 
            this.gbNewType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbNewType.Controls.Add(this.rdbTwinU);
            this.gbNewType.Controls.Add(this.rdbFamilyU);
            this.gbNewType.Controls.Add(this.rdbDoubleU);
            this.gbNewType.Controls.Add(this.rdbSingleU);
            this.gbNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNewType.Location = new System.Drawing.Point(463, 219);
            this.gbNewType.Name = "gbNewType";
            this.gbNewType.Size = new System.Drawing.Size(386, 70);
            this.gbNewType.TabIndex = 45;
            this.gbNewType.TabStop = false;
            // 
            // rdbTwinU
            // 
            this.rdbTwinU.AutoSize = true;
            this.rdbTwinU.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTwinU.Location = new System.Drawing.Point(301, 32);
            this.rdbTwinU.Name = "rdbTwinU";
            this.rdbTwinU.Size = new System.Drawing.Size(72, 28);
            this.rdbTwinU.TabIndex = 3;
            this.rdbTwinU.TabStop = true;
            this.rdbTwinU.Text = "Twin";
            this.rdbTwinU.UseVisualStyleBackColor = true;
            // 
            // rdbFamilyU
            // 
            this.rdbFamilyU.AutoSize = true;
            this.rdbFamilyU.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFamilyU.Location = new System.Drawing.Point(199, 32);
            this.rdbFamilyU.Name = "rdbFamilyU";
            this.rdbFamilyU.Size = new System.Drawing.Size(87, 28);
            this.rdbFamilyU.TabIndex = 2;
            this.rdbFamilyU.TabStop = true;
            this.rdbFamilyU.Text = "Family";
            this.rdbFamilyU.UseVisualStyleBackColor = true;
            // 
            // rdbDoubleU
            // 
            this.rdbDoubleU.AutoSize = true;
            this.rdbDoubleU.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoubleU.Location = new System.Drawing.Point(104, 32);
            this.rdbDoubleU.Name = "rdbDoubleU";
            this.rdbDoubleU.Size = new System.Drawing.Size(92, 28);
            this.rdbDoubleU.TabIndex = 1;
            this.rdbDoubleU.TabStop = true;
            this.rdbDoubleU.Text = "Double";
            this.rdbDoubleU.UseVisualStyleBackColor = true;
            // 
            // rdbSingleU
            // 
            this.rdbSingleU.AutoSize = true;
            this.rdbSingleU.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingleU.Location = new System.Drawing.Point(15, 32);
            this.rdbSingleU.Name = "rdbSingleU";
            this.rdbSingleU.Size = new System.Drawing.Size(83, 28);
            this.rdbSingleU.TabIndex = 0;
            this.rdbSingleU.TabStop = true;
            this.rdbSingleU.Text = "Single";
            this.rdbSingleU.UseVisualStyleBackColor = true;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(463, 345);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(386, 44);
            this.txtCapacity.TabIndex = 44;
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNumber.Location = new System.Drawing.Point(463, 169);
            this.txtNewNumber.Multiline = true;
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(386, 44);
            this.txtNewNumber.TabIndex = 43;
            this.txtNewNumber.TextChanged += new System.EventHandler(this.txtNewNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(133, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Room Capacity :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(133, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Room Number :-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(133, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 32);
            this.label6.TabIndex = 40;
            this.label6.Text = "Room Type :-";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(662, 559);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 47);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(463, 559);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 47);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 100);
            this.panel3.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(233, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(625, 59);
            this.label16.TabIndex = 0;
            this.label16.Text = "Update And Delete Room";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 755);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoom";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.gbRoomType.ResumeLayout(false);
            this.gbRoomType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.gbNewType.ResumeLayout(false);
            this.gbNewType.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbRoomType;
        private System.Windows.Forms.RadioButton rdbDouble;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbTwin;
        private System.Windows.Forms.RadioButton rdbFamily;
        private System.Windows.Forms.TextBox txtRoomDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbNewType;
        private System.Windows.Forms.RadioButton rdbTwinU;
        private System.Windows.Forms.RadioButton rdbFamilyU;
        private System.Windows.Forms.RadioButton rdbDoubleU;
        private System.Windows.Forms.RadioButton rdbSingleU;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCapacity;
    }
}