using System;
using System.IO;
using System.Net;
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

            response.Close();
        }
    }
}
