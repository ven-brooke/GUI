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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.IO;

namespace GUI
{
    public partial class FormMain : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        public FormMain()
        {
            InitializeComponent();

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menupanel.Visible = true;
            MyCart.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menupanel.Visible = false;
            MyCart.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb");

            da = new OleDbDataAdapter("SELECT Orders.SaleID, Orders.ItemOrder, Orders.OrderQty, Orders.ItemSubtotal, Orders.OrderDate\r\nFROM Orders;\r\n", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Orders");
            dataGridView2.DataSource = ds.Tables["Orders"];
            myConn.Close();
            try
            {
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb"))
                {
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("SELECT SUM(ItemSubtotal) FROM Orders", myConn)) 
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            decimal total = Convert.ToDecimal(result);
                            label3.Text = "Total: Php " + total.ToString("C"); // Display the total value in the Label
                        }
                        else
                        {
                            label3.Text = "Total: Php 0.00"; // Display $0.00 if the result is null
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb");

            da = new OleDbDataAdapter("SELECT Items.[StockID], Items.[Item], Items.[Unit price] FROM Items", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Items");
            dataGridView3.DataSource = ds.Tables["Items"];
            myConn.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[indexRow];
            textBox1.Text = row.Cells[1].Value.ToString() + ", Php" + row.Cells[2].Value.ToString() + ".00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string mainconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
                OleDbConnection conn = new OleDbConnection(mainconn);
                conn.Open();
                string olequery = "INSERT INTO Orders (ItemOrder, OrderQty, ItemSubtotal, OrderDate) values (@ItemOrder, @OrderQty, @ItemSubtotal, @OrderDate)";
                OleDbCommand comm = new OleDbCommand(olequery, conn);
                comm.Parameters.AddWithValue("@ItemOrder", comboBox1.Text.ToString());
                comm.Parameters.AddWithValue("@OrderQty", textBox3.Text);

                // Retrieve the Item Price from Items table
                string selectOleDb = "SELECT [Unit price] FROM Items WHERE Item = @item";
                OleDbCommand selectCommand = new OleDbCommand(selectOleDb, conn);
                selectCommand.Parameters.AddWithValue("@item", comboBox1.Text);
                object itemPrice = selectCommand.ExecuteScalar();
                int orderQty = int.Parse(textBox3.Text);
                double itemSubtotal = Convert.ToDouble(itemPrice) * orderQty; // calculate ItemSubtotal
                comm.Parameters.AddWithValue("@ItemSubtotal", itemSubtotal);

                // Add the OrderDate parameter
                comm.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);

                comm.ExecuteNonQuery();
                MessageBox.Show("Selected: " + comboBox1.Text + ", " + textBox3.Text);
                conn.Close();

                // Update the quantity in the Items table
                int valueToSubtract = int.Parse(textBox3.Text);

                string selectedItem = comboBox1.SelectedItem.ToString();

                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                string selectOleDb1 = "SELECT Quantity FROM Items WHERE Item = @item";

                OleDbCommand selectCommand1 = new OleDbCommand(selectOleDb1, connection);

                selectCommand1.Parameters.AddWithValue("@item", selectedItem);

                int currentQuantity = (int)selectCommand1.ExecuteScalar();

                int newQuantity = currentQuantity - valueToSubtract;

                string updateOle = "UPDATE Items SET Quantity = @quantity WHERE Item = @item";

                OleDbCommand updateCommand = new OleDbCommand(updateOle, connection);

                updateCommand.Parameters.AddWithValue("@quantity", newQuantity);
                updateCommand.Parameters.AddWithValue("@item", selectedItem);

                updateCommand.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Try loading TABLE first or selecting DATE");
            }
        }
            

        private void comboBox1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                myConn.Open();
                OleDbCommand command = myConn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Item FROM Items";
                //command.CommandText = "SELECT Item, [Unit Price] FROM Items";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["Item"].ToString());
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Load the MENU LIST first!");
                MessageBox.Show("Error: " + ex.Message); // Display exception message in a MessageBox

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a valid cell (not the header or empty row)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Get the values of the selected item
                string itemOrder = row.Cells["ItemOrder"].Value.ToString();
                int itemSubtotal = int.Parse(row.Cells["ItemSubtotal"].Value.ToString());
                int quantity = int.Parse(row.Cells["OrderQty"].Value.ToString());
                // Display the selected item in a TextBox for the user to enter the invoice number
                //textBox2.Text = itemOrder;
                textBox2.Text = row.Cells[1].Value.ToString() + ", Qty: " + quantity + ", Php" + row.Cells[3].Value.ToString() + ".00";
                // Save the selected item when the user clicks the Save button
                button4.Click += (s, ev) =>
                {
                    try
                    {
                        // Get the invoice number from the TextBox
                        string invoiceNumber = textBox4.Text;

                        // Insert the values into the Receipts table
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = myConn; // your OleDbConnection object
                        myConn.Open();
                        cmd.CommandText = "INSERT INTO Receipts (InvoiceNumber, Items, Qty, TotalPrice, InvDate) VALUES (@InvoiceNumber, @Items, @Qty, @TotalPrice, @InvDate)";
                        cmd.Parameters.AddWithValue("InvoiceNumber", invoiceNumber);
                        cmd.Parameters.AddWithValue("Items", itemOrder);
                        cmd.Parameters.AddWithValue("Qty", quantity);
                        cmd.Parameters.AddWithValue("TotalPrice", itemSubtotal);

                        // Retrieve the OrderDate from the Orders table
                        string selectOleDb = "SELECT OrderDate FROM Orders WHERE ItemOrder = @itemOrder";
                        OleDbCommand selectCommand = new OleDbCommand(selectOleDb, myConn);
                        selectCommand.Parameters.AddWithValue("@itemOrder", itemOrder);
                        object orderDate = selectCommand.ExecuteScalar();
                        cmd.Parameters.AddWithValue("@InvDate", orderDate);

                        cmd.ExecuteNonQuery();
                        myConn.Close();

                        // Clear the TextBox and show a success message
                        textBox4.Text = "";
                        MessageBox.Show("Item saved successfully!");
                        // Remove the click event handler from the Save button to prevent duplicate inserts
                        button4.Click -= new EventHandler((s1, ev1) => { });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in saving: " + ex.Message);
                    }
                };
            }

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView2.SelectedCells[0].RowIndex;
                    string saleId = dataGridView2.Rows[rowIndex].Cells["SaleID"].Value.ToString(); // Assuming "SaleID" is the column name for the primary key in your database

                    using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb"))
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand("DELETE FROM Orders WHERE SaleID = @SaleID", connection)) // Using parameterized query to prevent SQL injection
                        {
                            command.Parameters.AddWithValue("@SaleID", saleId); // Adding parameter with value to the query
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    dataGridView2.Rows.RemoveAt(rowIndex); // Remove row from the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
                  
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

