namespace TestProject
{
    partial class frmRegister
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblLinkLogin = new System.Windows.Forms.LinkLabel();
            this.txtUsernameSU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumberSU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswordSU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmPasswordSU = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(148, 595);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Have an existing account?";
            // 
            // lblLinkLogin
            // 
            this.lblLinkLogin.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblLinkLogin.AutoSize = true;
            this.lblLinkLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinkLogin.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.lblLinkLogin.Location = new System.Drawing.Point(335, 595);
            this.lblLinkLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkLogin.Name = "lblLinkLogin";
            this.lblLinkLogin.Size = new System.Drawing.Size(91, 19);
            this.lblLinkLogin.TabIndex = 22;
            this.lblLinkLogin.TabStop = true;
            this.lblLinkLogin.Text = "Login here";
            this.lblLinkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtUsernameSU
            // 
            this.txtUsernameSU.Animated = true;
            this.txtUsernameSU.AutoRoundedCorners = true;
            this.txtUsernameSU.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameSU.BorderRadius = 24;
            this.txtUsernameSU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameSU.DefaultText = "";
            this.txtUsernameSU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameSU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameSU.Location = new System.Drawing.Point(51, 138);
            this.txtUsernameSU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsernameSU.Name = "txtUsernameSU";
            this.txtUsernameSU.PasswordChar = '\0';
            this.txtUsernameSU.PlaceholderText = "Enter Username";
            this.txtUsernameSU.SelectedText = "";
            this.txtUsernameSU.Size = new System.Drawing.Size(461, 51);
            this.txtUsernameSU.TabIndex = 23;
            this.txtUsernameSU.TextChanged += new System.EventHandler(this.txtUsernameSU_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(51, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(145, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Create an Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.AutoRoundedCorners = true;
            this.btnRegister.BorderRadius = 25;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnRegister.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(232)))));
            this.btnRegister.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnRegister.Location = new System.Drawing.Point(51, 525);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(461, 53);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone Number";
            // 
            // txtPhoneNumberSU
            // 
            this.txtPhoneNumberSU.Animated = true;
            this.txtPhoneNumberSU.AutoRoundedCorners = true;
            this.txtPhoneNumberSU.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumberSU.BorderRadius = 24;
            this.txtPhoneNumberSU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumberSU.DefaultText = "";
            this.txtPhoneNumberSU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumberSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumberSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumberSU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumberSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumberSU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumberSU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumberSU.Location = new System.Drawing.Point(51, 239);
            this.txtPhoneNumberSU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumberSU.Name = "txtPhoneNumberSU";
            this.txtPhoneNumberSU.PasswordChar = '\0';
            this.txtPhoneNumberSU.PlaceholderText = "Enter Phone Number";
            this.txtPhoneNumberSU.SelectedText = "";
            this.txtPhoneNumberSU.Size = new System.Drawing.Size(461, 51);
            this.txtPhoneNumberSU.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(51, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Password";
            // 
            // txtPasswordSU
            // 
            this.txtPasswordSU.Animated = true;
            this.txtPasswordSU.AutoRoundedCorners = true;
            this.txtPasswordSU.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordSU.BorderRadius = 24;
            this.txtPasswordSU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordSU.DefaultText = "";
            this.txtPasswordSU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSU.Location = new System.Drawing.Point(51, 340);
            this.txtPasswordSU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordSU.Name = "txtPasswordSU";
            this.txtPasswordSU.PasswordChar = '*';
            this.txtPasswordSU.PlaceholderText = "Enter Password";
            this.txtPasswordSU.SelectedText = "";
            this.txtPasswordSU.Size = new System.Drawing.Size(461, 51);
            this.txtPasswordSU.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(51, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Confirm Password";
            // 
            // txtConfirmPasswordSU
            // 
            this.txtConfirmPasswordSU.Animated = true;
            this.txtConfirmPasswordSU.AutoRoundedCorners = true;
            this.txtConfirmPasswordSU.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPasswordSU.BorderRadius = 24;
            this.txtConfirmPasswordSU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPasswordSU.DefaultText = "";
            this.txtConfirmPasswordSU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPasswordSU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPasswordSU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPasswordSU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPasswordSU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPasswordSU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordSU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPasswordSU.Location = new System.Drawing.Point(51, 441);
            this.txtConfirmPasswordSU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPasswordSU.Name = "txtConfirmPasswordSU";
            this.txtConfirmPasswordSU.PasswordChar = '*';
            this.txtConfirmPasswordSU.PlaceholderText = "Enter Confirm Password";
            this.txtConfirmPasswordSU.SelectedText = "";
            this.txtConfirmPasswordSU.Size = new System.Drawing.Size(461, 51);
            this.txtConfirmPasswordSU.TabIndex = 31;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 654);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtConfirmPasswordSU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPasswordSU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhoneNumberSU);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsernameSU);
            this.Controls.Add(this.lblLinkLogin);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblLinkLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameSU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnRegister;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumberSU;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordSU;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPasswordSU;
    }
}