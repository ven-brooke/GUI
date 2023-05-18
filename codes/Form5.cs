using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4Login_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from text boxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate input data (e.g., check for empty fields, length requirements, etc.)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            try
            {
                // Connect to the admin database table
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb"))
                {
                    connection.Open();

                    // Check if username already exists in the database
                    string checkQuery = "SELECT COUNT(*) FROM Admin WHERE Username = @Username";
                    using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return;
                        }
                    }
                    // Construct the SQL query to insert username and password
                    string query = "INSERT INTO Admin(Username, [Password]) VALUES(@Username, @Password)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Username and password added successfully.");
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add username and password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
