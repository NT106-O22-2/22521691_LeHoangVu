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

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getHTML(string szURL)
        {
            //Creata a request for the URL.
            WebRequest requestt = WebRequest.Create(szURL);
            //Get the response.
            WebResponse response = requestt.GetResponse();
            //Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            //Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            //Read the content.
            string responseFromServer = reader.ReadToEnd();
            //Close the response.
            reader.Close();
            return responseFromServer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var html = getHTML(this.textBox1.Text);
            richTextBox1.Text = html;
        }
    }
}
