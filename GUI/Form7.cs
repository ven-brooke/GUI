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

namespace GUI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb");

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Receipts.InvoiceNumber, Receipts.Items, Receipts.TotalPrice, Receipts.Qty, Receipts.InvDate\r\nFROM Receipts;\r\n", myConn);
            DataSet ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Receipts");
            dataGridView1.DataSource = ds.Tables["Receipts"];
            myConn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
            string query = "SELECT InvoiceNumber, Items, TotalPrice, Qty, InvDate FROM Receipts WHERE InvDate >= ? AND InvDate < ? ORDER BY InvDate ASC";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                try
                {
                    DateTime startDate = dateTimePicker1.Value.Date;
                    DateTime endDate = dateTimePicker2.Value.Date.AddDays(1);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
            // Get the selected item in the ComboBox
            string selectedValue = comboBox1.SelectedItem.ToString();

            // Determine which query to execute based on the selected item
            string query;
            try
            {
                switch (selectedValue)
                {
                    case "Daily":
                        query = "SELECT DATEVALUE(Receipts.InvDate) AS InvDate, SUM(Receipts.TotalPrice) AS TotalSales FROM Receipts GROUP BY DATEVALUE(Receipts.InvDate);";
                        break;
                    case "Monthly":
                        query = "SELECT YEAR(Receipts.[InvDate]) AS [Year], MONTH(Receipts.[InvDate]) AS [Month], SUM(Receipts.[TotalPrice]) AS TotalSales " +
            "FROM Receipts " +
            "GROUP BY YEAR(Receipts.[InvDate]), MONTH(Receipts.[InvDate]);";
                        break;
                    case "Yearly":
                        query = "SELECT YEAR(Receipts.InvDate) AS SalesYear, SUM(Receipts.TotalPrice) AS TotalSales FROM Receipts GROUP BY YEAR(Receipts.InvDate);";
                        break;
                    default:
                        // Set a default query in case no valid option is selected
                        query = "SELECT Receipts.InvoiceNumber, Receipts.Items, Receipts.TotalPrice, Receipts.Qty, Receipts.InvDate FROM Receipts;";
                        break;
                }
                // Execute the query and populate the DataGridView with the results
                OleDbConnection myConn = new OleDbConnection(connectionString);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, myConn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
