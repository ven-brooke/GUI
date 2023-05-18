namespace GUI
{
    partial class Form3
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
            this.Toppanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.CUSTOMER = new System.Windows.Forms.Button();
            this.ADMIN = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Panel();
            this.Toppanel.SuspendLayout();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Moccasin;
            this.Toppanel.Controls.Add(this.title);
            this.Toppanel.Controls.Add(this.splitter1);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(501, 95);
            this.Toppanel.TabIndex = 2;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Moccasin;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Rage Italic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(109, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(284, 61);
            this.title.TabIndex = 8;
            this.title.Text = "Juno\'s Kitchen";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(14, 95);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // CUSTOMER
            // 
            this.CUSTOMER.BackColor = System.Drawing.Color.Moccasin;
            this.CUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.CUSTOMER.FlatAppearance.BorderSize = 3;
            this.CUSTOMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CUSTOMER.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER.Location = new System.Drawing.Point(312, 63);
            this.CUSTOMER.Name = "CUSTOMER";
            this.CUSTOMER.Size = new System.Drawing.Size(140, 63);
            this.CUSTOMER.TabIndex = 1;
            this.CUSTOMER.Text = "CUSTOMER";
            this.CUSTOMER.UseVisualStyleBackColor = false;
            this.CUSTOMER.Click += new System.EventHandler(this.CUSTOMER_Click);
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.Color.Moccasin;
            this.ADMIN.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.ADMIN.FlatAppearance.BorderSize = 4;
            this.ADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADMIN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMIN.Location = new System.Drawing.Point(112, 63);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(117, 63);
            this.ADMIN.TabIndex = 0;
            this.ADMIN.Text = "ADMIN";
            this.ADMIN.UseVisualStyleBackColor = false;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.BurlyWood;
            this.Login.Controls.Add(this.CUSTOMER);
            this.Login.Controls.Add(this.ADMIN);
            this.Login.Location = new System.Drawing.Point(-35, 87);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(536, 184);
            this.Login.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 264);
            this.Controls.Add(this.Toppanel);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.Login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button CUSTOMER;
        private System.Windows.Forms.Button ADMIN;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.TextBox title;
    }
}