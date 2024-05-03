using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    webView.Source = new Uri(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading URL: " + ex.Message);
                }
            }
        }

        private void downFileBtn_Click(object sender, EventArgs e)
        {

        }

        private void downResourcesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
