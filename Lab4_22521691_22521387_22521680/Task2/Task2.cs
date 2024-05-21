using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex htmlRegex = new Regex("\\b\\w+\\.html\\b");
                if (htmlRegex.IsMatch(textBox2.Text) && textBox1 != null)
                {
                    richTextBox1.Text = "";
                    WebRequest request = WebRequest.Create(textBox1.Text);
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    richTextBox1.Text = reader.ReadToEnd();

                    System.IO.File.WriteAllText(textBox2.Text, richTextBox1.Text);
                    MessageBox.Show("Webpage downloaded successfully.");

                    response.Close();
                } else MessageBox.Show("Data entry error.");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
