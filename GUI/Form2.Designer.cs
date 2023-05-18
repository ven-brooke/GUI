namespace GUI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.button4Login = new System.Windows.Forms.Button();
            this.pWordtxtbox = new System.Windows.Forms.TextBox();
            this.uNametxtbox = new System.Windows.Forms.TextBox();
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
            this.LoginAdmin.Controls.Add(this.label1);
            this.LoginAdmin.Controls.Add(this.title);
            this.LoginAdmin.Controls.Add(this.button4Login);
            this.LoginAdmin.Controls.Add(this.pWordtxtbox);
            this.LoginAdmin.Controls.Add(this.uNametxtbox);
            this.LoginAdmin.Controls.Add(this.label5);
            this.LoginAdmin.Controls.Add(this.label3);
            this.LoginAdmin.Location = new System.Drawing.Point(26, 27);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(467, 226);
            this.LoginAdmin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forgot Password?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Moccasin;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Rage Italic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(90, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(284, 61);
            this.title.TabIndex = 5;
            this.title.Text = "Juno\'s Kitchen";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4Login
            // 
            this.button4Login.BackColor = System.Drawing.Color.Linen;
            this.button4Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4Login.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4Login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4Login.Location = new System.Drawing.Point(183, 165);
            this.button4Login.Name = "button4Login";
            this.button4Login.Size = new System.Drawing.Size(75, 28);
            this.button4Login.TabIndex = 4;
            this.button4Login.Text = "Login";
            this.button4Login.UseVisualStyleBackColor = false;
            this.button4Login.Click += new System.EventHandler(this.button4Login_Click);
            // 
            // pWordtxtbox
            // 
            this.pWordtxtbox.Location = new System.Drawing.Point(231, 120);
            this.pWordtxtbox.Name = "pWordtxtbox";
            this.pWordtxtbox.PasswordChar = '*';
            this.pWordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.pWordtxtbox.TabIndex = 3;
            this.pWordtxtbox.UseSystemPasswordChar = true;
            // 
            // uNametxtbox
            // 
            this.uNametxtbox.Location = new System.Drawing.Point(231, 92);
            this.uNametxtbox.Name = "uNametxtbox";
            this.uNametxtbox.Size = new System.Drawing.Size(100, 20);
            this.uNametxtbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(515, 288);
            this.Controls.Add(this.LoginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.LoginAdmin.ResumeLayout(false);
            this.LoginAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginAdmin;
        private System.Windows.Forms.Button button4Login;
        private System.Windows.Forms.TextBox pWordtxtbox;
        private System.Windows.Forms.TextBox uNametxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
    }
}