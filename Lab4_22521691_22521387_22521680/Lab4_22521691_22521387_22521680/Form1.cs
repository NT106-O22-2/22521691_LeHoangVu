using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_22521691_22521387_22521680
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            WebRequest request = WebRequest.Create(textBox1.Text);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            richTextBox1.Text = reader.ReadToEnd();
            /*string[] lines = reader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
                textBox2.Text += line + "\n";*/

            response.Close();
        }
    }
}
