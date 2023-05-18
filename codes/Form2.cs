using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4Login_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb");
            string Username, Password;
            Username = uNametxtbox.Text;
            Password = pWordtxtbox.Text;
            
            try 
            {
                string query = "SELECT * FROM Admin WHERE Username = '" + uNametxtbox.Text + "' AND Password =  '" + pWordtxtbox.Text + "'  ";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Username = uNametxtbox.Text;
                    Password = pWordtxtbox.Text;
                    Form3 form = new Form3();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uNametxtbox.Clear();
                    pWordtxtbox.Clear();
                    uNametxtbox.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Error. Try again");
            }
            finally
            {
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
