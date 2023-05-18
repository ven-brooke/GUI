using Microsoft.Reporting.WinForms;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get the invoice number from the textbox
            string invoiceNumber = textBox1.Text;

            // Fill the dataset with only the data that matches the invoice number
            GUIdatabaseDataSet3 m = new GUIdatabaseDataSet3();
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Documents\\Y2_S2\\CPE262_OOP2\\GUI\\GUIdatabase.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Receipts where InvoiceNumber='" + invoiceNumber + "'", con);
            da.Fill(m, m.Tables[0].TableName);

            GUIdatabaseDataSet4 m2 = new GUIdatabaseDataSet4();
            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT Receipts.InvoiceNumber, Sum(Receipts.TotalPrice) AS Total FROM Receipts WHERE Receipts.InvoiceNumber='" + invoiceNumber + "' GROUP BY Receipts.InvoiceNumber", con);
            da2.Fill(m2, m2.Tables[0].TableName);

            // Set the report data source to the filtered dataset
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", m.Tables[0]));
            reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", m2.Tables[0]));
            reportViewer3.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            reportViewer3.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }
    }
}
