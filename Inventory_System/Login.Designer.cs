using System;

namespace Inventory_System
{
    partial class login
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

        internal string loginDetails(object userID, object user)
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRegisterNew = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblForgotPassword.Location = new System.Drawing.Point(117, 376);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(116, 17);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Forgot password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(7, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(321, 56);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(40, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(40, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(288, 30);
            this.txtUsername.TabIndex = 0;
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.lblLogin);
            this.loginpanel.Controls.Add(this.lblRegisterNew);
            this.loginpanel.Controls.Add(this.lblErrorMsg);
            this.loginpanel.Controls.Add(this.lblForgotPassword);
            this.loginpanel.Controls.Add(this.txtUsername);
            this.loginpanel.Controls.Add(this.passwordIcon);
            this.loginpanel.Controls.Add(this.btnLogin);
            this.loginpanel.Controls.Add(this.userIcon);
            this.loginpanel.Controls.Add(this.txtPassword);
            this.loginpanel.Location = new System.Drawing.Point(21, 51);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(336, 407);
            this.loginpanel.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Location = new System.Drawing.Point(129, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(77, 30);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // lblRegisterNew
            // 
            this.lblRegisterNew.AutoSize = true;
            this.lblRegisterNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterNew.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegisterNew.Location = new System.Drawing.Point(81, 330);
            this.lblRegisterNew.Name = "lblRegisterNew";
            this.lblRegisterNew.Size = new System.Drawing.Size(201, 16);
            this.lblRegisterNew.TabIndex = 7;
            this.lblRegisterNew.Text = "Don\'t have an account? Register";
            this.lblRegisterNew.Click += new System.EventHandler(this.lblRegisterNew_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.SystemColors.Info;
            this.lblErrorMsg.Location = new System.Drawing.Point(4, 61);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 6;
            // 
            // passwordIcon
            // 
            this.passwordIcon.Image = global::Inventory_System.Properties.Resources.padlock;
            this.passwordIcon.Location = new System.Drawing.Point(7, 159);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(32, 27);
            this.passwordIcon.TabIndex = 3;
            this.passwordIcon.TabStop = false;
            this.passwordIcon.Click += new System.EventHandler(this.passwordIcon_Click);
            // 
            // userIcon
            // 
            this.userIcon.Image = global::Inventory_System.Properties.Resources.user_black;
            this.userIcon.Location = new System.Drawing.Point(6, 94);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(32, 27);
            this.userIcon.TabIndex = 1;
            this.userIcon.TabStop = false;
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseLogin.Location = new System.Drawing.Point(342, 7);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(30, 30);
            this.btnCloseLogin.TabIndex = 7;
            this.btnCloseLogin.Text = "x";
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(378, 470);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label lblRegisterNew;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCloseLogin;
    }
}

