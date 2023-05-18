﻿namespace GUI
{
    partial class Form5
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
            this.LoginAdmin = new System.Windows.Forms.Panel();
            this.button4Login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginAdmin
            // 
            this.LoginAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginAdmin.BackColor = System.Drawing.Color.Moccasin;
            this.LoginAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginAdmin.Controls.Add(this.button4Login);
            this.LoginAdmin.Controls.Add(this.txtPassword);
            this.LoginAdmin.Controls.Add(this.txtUsername);
            this.LoginAdmin.Controls.Add(this.label5);
            this.LoginAdmin.Controls.Add(this.label3);
            this.LoginAdmin.Location = new System.Drawing.Point(12, 12);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(312, 134);
            this.LoginAdmin.TabIndex = 5;
            // 
            // button4Login
            // 
            this.button4Login.BackColor = System.Drawing.Color.Linen;
            this.button4Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4Login.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4Login.Location = new System.Drawing.Point(112, 82);
            this.button4Login.Name = "button4Login";
            this.button4Login.Size = new System.Drawing.Size(75, 28);
            this.button4Login.TabIndex = 4;
            this.button4Login.Text = "Login";
            this.button4Login.UseVisualStyleBackColor = false;
            this.button4Login.Click += new System.EventHandler(this.button4Login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(172, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(172, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(336, 158);
            this.Controls.Add(this.LoginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.LoginAdmin.ResumeLayout(false);
            this.LoginAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginAdmin;
        private System.Windows.Forms.Button button4Login;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}