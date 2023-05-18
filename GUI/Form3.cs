using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            FormMain form1 = new FormMain();
            form1.Show();
            this.Hide();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
