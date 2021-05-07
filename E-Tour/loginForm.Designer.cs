
namespace E_Tour
{
    partial class loginForm
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
            this.usernameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.passwordTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.newLb = new Guna.UI.WinForms.GunaLabel();
            this.forgotLb = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // usernameTb
            // 
            this.usernameTb.BackColor = System.Drawing.Color.White;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTb.HideSelection = false;
            this.usernameTb.LineColor = System.Drawing.Color.Gainsboro;
            this.usernameTb.Location = new System.Drawing.Point(857, 247);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(351, 47);
            this.usernameTb.TabIndex = 0;
            this.usernameTb.Text = "User Name";
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.White;
            this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.passwordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTb.HideSelection = false;
            this.passwordTb.LineColor = System.Drawing.Color.Gainsboro;
            this.passwordTb.Location = new System.Drawing.Point(857, 342);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '●';
            this.passwordTb.SelectedText = "";
            this.passwordTb.Size = new System.Drawing.Size(351, 47);
            this.passwordTb.TabIndex = 1;
            this.passwordTb.Text = "Password";
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AutoRoundedCorners = true;
            this.loginBtn.BorderRadius = 21;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(954, 458);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(153, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // newLb
            // 
            this.newLb.AutoSize = true;
            this.newLb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(175)))));
            this.newLb.Location = new System.Drawing.Point(967, 518);
            this.newLb.Name = "newLb";
            this.newLb.Size = new System.Drawing.Size(128, 28);
            this.newLb.TabIndex = 3;
            this.newLb.Text = "Create Acount";
            this.newLb.Click += new System.EventHandler(this.newLb_Click);
            // 
            // forgotLb
            // 
            this.forgotLb.AutoSize = true;
            this.forgotLb.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(175)))));
            this.forgotLb.Location = new System.Drawing.Point(960, 644);
            this.forgotLb.Name = "forgotLb";
            this.forgotLb.Size = new System.Drawing.Size(151, 28);
            this.forgotLb.TabIndex = 4;
            this.forgotLb.Text = "Forgot Password?";
            this.forgotLb.Click += new System.EventHandler(this.forgotLb_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.loginBackground_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.forgotLb);
            this.Controls.Add(this.newLb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Text = "Login to E-Tour";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox usernameTb;
        private Guna.UI.WinForms.GunaLineTextBox passwordTb;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaLabel newLb;
        private Guna.UI.WinForms.GunaLabel forgotLb;
    }
}

