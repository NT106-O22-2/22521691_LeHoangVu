using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Net;

namespace Bai03
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            webView21.Source = new Uri(url);
        }

        private void btnDownResources_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(txtUrl.Text);

            var imgs = htmlDoc.DocumentNode.SelectNodes("//img");
            if (imgs != null)
            {
                using (var client = new HttpClient())
                {
                    foreach (var img in imgs)
                    {
                        var imgURL = img.GetAttributeValue("src", "");

                        MessageBox.Show(imgURL);
                    }
                    MessageBox.Show("Tải tất cả hình ảnh thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh nào để tải!");
            }
        }

        private void btnDownFiles_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(txtUrl.Text);

            var html = htmlDoc.DocumentNode.OuterHtml;
            var htmlFileName = "website.html";
            var htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, htmlFileName);

            File.WriteAllText(htmlFilePath, html);

            MessageBox.Show($"Tải HTML của trang web thành công và lưu vào {htmlFileName}!");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void btnViewSource_Click_1(object sender, EventArgs e)
        {
            var html = getHTML(this.txtUrl.Text);
            var form = new Form();
            form.Text = "HTML Source";
            form.Width = 800;
            form.Height = 600;

            var txtBox = new RichTextBox();
            txtBox.Dock = DockStyle.Fill;
            txtBox.Multiline = true;
            txtBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBox.Text = html;

            form.Controls.Add(txtBox);
            form.ShowDialog();
        }
    }
}
