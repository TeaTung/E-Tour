
namespace E_Tour
{
    partial class signupForm
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
            this.components = new System.ComponentModel.Container();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.txbPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.txbUserName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txbAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.txbPhoneNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.txbEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.forgotLb = new Guna.UI.WinForms.GunaLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txbCitizenID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txbFullName = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtpExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblExpiration = new Guna.UI.WinForms.GunaLabel();
            this.cbbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AutoRoundedCorners = true;
            this.loginBtn.BorderRadius = 23;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(827, 607);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(138, 48);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Sign Up";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPassword.HideSelection = false;
            this.txbPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.txbPassword.Location = new System.Drawing.Point(568, 220);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '●';
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(300, 45);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.Text = "Password";
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.White;
            this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUserName.HideSelection = false;
            this.txbUserName.LineColor = System.Drawing.Color.Gainsboro;
            this.txbUserName.Location = new System.Drawing.Point(568, 120);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.SelectedText = "";
            this.txbUserName.Size = new System.Drawing.Size(300, 45);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = "User Name";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.White;
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAddress.HideSelection = false;
            this.txbAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.txbAddress.Location = new System.Drawing.Point(932, 320);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PasswordChar = '\0';
            this.txbAddress.SelectedText = "";
            this.txbAddress.Size = new System.Drawing.Size(300, 45);
            this.txbAddress.TabIndex = 4;
            this.txbAddress.Text = "Address";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhoneNumber.HideSelection = false;
            this.txbPhoneNumber.LineColor = System.Drawing.Color.Gainsboro;
            this.txbPhoneNumber.Location = new System.Drawing.Point(932, 220);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.PasswordChar = '\0';
            this.txbPhoneNumber.SelectedText = "";
            this.txbPhoneNumber.Size = new System.Drawing.Size(300, 45);
            this.txbPhoneNumber.TabIndex = 5;
            this.txbPhoneNumber.Text = "Phone Numer";
            this.txbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTb_KeyPress);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEmail.HideSelection = false;
            this.txbEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txbEmail.Location = new System.Drawing.Point(568, 320);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(300, 45);
            this.txbEmail.TabIndex = 3;
            this.txbEmail.Text = "Email";
            // 
            // forgotLb
            // 
            this.forgotLb.AutoSize = true;
            this.forgotLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(175)))));
            this.forgotLb.Location = new System.Drawing.Point(811, 665);
            this.forgotLb.Name = "forgotLb";
            this.forgotLb.Size = new System.Drawing.Size(175, 20);
            this.forgotLb.TabIndex = 9;
            this.forgotLb.Text = "Already Have Account?";
            this.forgotLb.Click += new System.EventHandler(this.forgotLb_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txbCitizenID
            // 
            this.txbCitizenID.BackColor = System.Drawing.Color.White;
            this.txbCitizenID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCitizenID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbCitizenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCitizenID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCitizenID.HideSelection = false;
            this.txbCitizenID.LineColor = System.Drawing.Color.Gainsboro;
            this.txbCitizenID.Location = new System.Drawing.Point(568, 420);
            this.txbCitizenID.Name = "txbCitizenID";
            this.txbCitizenID.PasswordChar = '\0';
            this.txbCitizenID.SelectedText = "";
            this.txbCitizenID.Size = new System.Drawing.Size(300, 45);
            this.txbCitizenID.TabIndex = 9;
            this.txbCitizenID.Text = "Citizen ID";
            // 
            // txbFullName
            // 
            this.txbFullName.BackColor = System.Drawing.Color.White;
            this.txbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFullName.HideSelection = false;
            this.txbFullName.LineColor = System.Drawing.Color.Gainsboro;
            this.txbFullName.Location = new System.Drawing.Point(932, 120);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.PasswordChar = '\0';
            this.txbFullName.SelectedText = "";
            this.txbFullName.Size = new System.Drawing.Size(300, 45);
            this.txbFullName.TabIndex = 6;
            this.txbFullName.Text = "Full Name";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dtpExpiration.BorderRadius = 1;
            this.dtpExpiration.BorderThickness = 2;
            this.dtpExpiration.CheckedState.Parent = this.dtpExpiration;
            this.dtpExpiration.FillColor = System.Drawing.Color.White;
            this.dtpExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpiration.HoverState.Parent = this.dtpExpiration;
            this.dtpExpiration.Location = new System.Drawing.Point(568, 533);
            this.dtpExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.ShadowDecoration.Parent = this.dtpExpiration;
            this.dtpExpiration.Size = new System.Drawing.Size(300, 36);
            this.dtpExpiration.TabIndex = 10;
            this.dtpExpiration.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            this.dtpExpiration.Visible = false;
            this.dtpExpiration.ValueChanged += new System.EventHandler(this.dtpExpiration_ValueChanged);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblExpiration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExpiration.Location = new System.Drawing.Point(567, 496);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(108, 25);
            this.lblExpiration.TabIndex = 88;
            this.lblExpiration.Text = "Expiration";
            this.lblExpiration.Visible = false;
            // 
            // cbbGender
            // 
            this.cbbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbbGender.BorderThickness = 2;
            this.cbbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGender.FocusedState.Parent = this.cbbGender;
            this.cbbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbGender.HoverState.Parent = this.cbbGender;
            this.cbbGender.ItemHeight = 30;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbbGender.ItemsAppearance.Parent = this.cbbGender;
            this.cbbGender.Location = new System.Drawing.Point(932, 431);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.ShadowDecoration.Parent = this.cbbGender;
            this.cbbGender.Size = new System.Drawing.Size(300, 36);
            this.cbbGender.TabIndex = 7;
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.Color.Transparent;
            this.cbbType.BorderThickness = 2;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbType.FocusedState.Parent = this.cbbType;
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbType.HoverState.Parent = this.cbbType;
            this.cbbType.ItemHeight = 30;
            this.cbbType.Items.AddRange(new object[] {
            "Aboard",
            "Home"});
            this.cbbType.ItemsAppearance.Parent = this.cbbType;
            this.cbbType.Location = new System.Drawing.Point(932, 533);
            this.cbbType.Name = "cbbType";
            this.cbbType.ShadowDecoration.Parent = this.cbbType;
            this.cbbType.Size = new System.Drawing.Size(300, 36);
            this.cbbType.TabIndex = 8;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged_1);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(931, 496);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 25);
            this.gunaLabel1.TabIndex = 91;
            this.gunaLabel1.Text = "Gender";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(931, 401);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel2.TabIndex = 92;
            this.gunaLabel2.Text = "Guest Type";
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.background_sign_up_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.txbCitizenID);
            this.Controls.Add(this.txbFullName);
            this.Controls.Add(this.forgotLb);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI.WinForms.GunaLineTextBox txbPassword;
        private Guna.UI.WinForms.GunaLineTextBox txbUserName;
        private Guna.UI.WinForms.GunaLineTextBox txbAddress;
        private Guna.UI.WinForms.GunaLineTextBox txbPhoneNumber;
        private Guna.UI.WinForms.GunaLineTextBox txbEmail;
        private Guna.UI.WinForms.GunaLabel forgotLb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaLineTextBox txbCitizenID;
        private Guna.UI.WinForms.GunaLineTextBox txbFullName;
        private Guna.UI.WinForms.GunaLabel lblExpiration;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiration;
        private Guna.UI2.WinForms.Guna2ComboBox cbbType;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGender;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}