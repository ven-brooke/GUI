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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form4 : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb");

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Items.[StockID], Items.[Item], Items.[Unit price], Items.[Quantity] FROM Items", myConn);
            DataSet ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Items");
            dataGridView1.DataSource = ds.Tables["Items"];
            myConn.Close();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }
        private int clickedRowIndex;
        private int clickedColumnIndex;
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the quantity to add from the textbox
                int quantityToAdd = Convert.ToInt32(textBox1.Text);

                // Get the item ID from the first column of the clicked row
                int itemID = Convert.ToInt32(dataGridView1.Rows[clickedRowIndex].Cells[0].Value);

                // Get the current quantity from the "Quantity" column of the clicked row
                int currentQuantity = Convert.ToInt32(dataGridView1.Rows[clickedRowIndex].Cells[clickedColumnIndex].Value);

                // Calculate the new quantity
                int newQuantity = currentQuantity + quantityToAdd;

                // Update the "Quantity" column of the clicked row in the database
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Items SET Quantity=@newQuantity WHERE StockID=@StockID";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newQuantity", newQuantity);
                        command.Parameters.AddWithValue("@StockID", itemID);
                        command.ExecuteNonQuery();
                    }
                }

                // Update the "Quantity" column of the clicked row in the DataGridView
                dataGridView1.Rows[clickedRowIndex].Cells[clickedColumnIndex].Value = newQuantity;

                // Clear the textbox and label
                textBox1.Clear();
                label1.Text = "";
            }
            catch
            {
                MessageBox.Show("Input QUANTITY first!");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            // Check if the clicked cell is the "Quantity" column
            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index)
            {
                // Store the clicked row index and column index in class-level variables, to use later in the button click event
                clickedRowIndex = e.RowIndex;
                clickedColumnIndex = e.ColumnIndex;

                // Display the current quantity in a label
                label1.Text = "Current quantity: " + dataGridView1.Rows[clickedRowIndex].Cells[clickedColumnIndex].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
