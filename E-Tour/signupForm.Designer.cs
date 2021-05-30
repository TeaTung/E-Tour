﻿
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
            this.passwordTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.usernameTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.addressTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.phoneTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.emailTb = new Guna.UI.WinForms.GunaLineTextBox();
            this.forgotLb = new Guna.UI.WinForms.GunaLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AutoRoundedCorners = true;
            this.loginBtn.BorderRadius = 21;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(981, 646);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(153, 45);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Sign Up";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
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
            this.passwordTb.Location = new System.Drawing.Point(876, 258);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '●';
            this.passwordTb.SelectedText = "";
            this.passwordTb.Size = new System.Drawing.Size(351, 47);
            this.passwordTb.TabIndex = 4;
            this.passwordTb.Text = "Password";
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // usernameTb
            // 
            this.usernameTb.BackColor = System.Drawing.Color.White;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTb.HideSelection = false;
            this.usernameTb.LineColor = System.Drawing.Color.Gainsboro;
            this.usernameTb.Location = new System.Drawing.Point(876, 163);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(351, 47);
            this.usernameTb.TabIndex = 3;
            this.usernameTb.Text = "User Name";
            // 
            // addressTb
            // 
            this.addressTb.BackColor = System.Drawing.Color.White;
            this.addressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTb.HideSelection = false;
            this.addressTb.LineColor = System.Drawing.Color.Gainsboro;
            this.addressTb.Location = new System.Drawing.Point(876, 354);
            this.addressTb.Name = "addressTb";
            this.addressTb.PasswordChar = '\0';
            this.addressTb.SelectedText = "";
            this.addressTb.Size = new System.Drawing.Size(351, 47);
            this.addressTb.TabIndex = 6;
            this.addressTb.Text = "Address";
            // 
            // phoneTb
            // 
            this.phoneTb.BackColor = System.Drawing.Color.White;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTb.HideSelection = false;
            this.phoneTb.LineColor = System.Drawing.Color.Gainsboro;
            this.phoneTb.Location = new System.Drawing.Point(876, 457);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.PasswordChar = '\0';
            this.phoneTb.SelectedText = "";
            this.phoneTb.Size = new System.Drawing.Size(351, 47);
            this.phoneTb.TabIndex = 7;
            this.phoneTb.Text = "Phone Numer";
            // 
            // emailTb
            // 
            this.emailTb.BackColor = System.Drawing.Color.White;
            this.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTb.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTb.HideSelection = false;
            this.emailTb.LineColor = System.Drawing.Color.Gainsboro;
            this.emailTb.Location = new System.Drawing.Point(876, 551);
            this.emailTb.Name = "emailTb";
            this.emailTb.PasswordChar = '\0';
            this.emailTb.SelectedText = "";
            this.emailTb.Size = new System.Drawing.Size(351, 47);
            this.emailTb.TabIndex = 8;
            this.emailTb.Text = "Email";
            // 
            // forgotLb
            // 
            this.forgotLb.AutoSize = true;
            this.forgotLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(175)))));
            this.forgotLb.Location = new System.Drawing.Point(871, 615);
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
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.signupBackground_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.forgotLb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
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
        private Guna.UI.WinForms.GunaLineTextBox passwordTb;
        private Guna.UI.WinForms.GunaLineTextBox usernameTb;
        private Guna.UI.WinForms.GunaLineTextBox addressTb;
        private Guna.UI.WinForms.GunaLineTextBox phoneTb;
        private Guna.UI.WinForms.GunaLineTextBox emailTb;
        private Guna.UI.WinForms.GunaLabel forgotLb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}