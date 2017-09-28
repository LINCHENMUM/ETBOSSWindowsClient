using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETBOSSWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ETBOSSService.ETBOSSServiceClient client = new ETBOSSService.ETBOSSServiceClient("NetTcpBinding_IETBOSSService");
            label1.Text = client.GetCustomerName(textBox1.Text);
        }

    }
}
