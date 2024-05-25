using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            string filePath = txtFilePath.Text;

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(filePath))
            {
                WebClient myClient = new WebClient();

                try
                {
                    Stream response = myClient.OpenRead(url);
                    myClient.DownloadFile(url, filePath);
                    MessageBox.Show("Nội dung trang web đã được tải về thành công và lưu vào " + filePath);
                    string htmlContent = File.ReadAllText(filePath);
                    richTextBox.Text = htmlContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải về trang web: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!");
            }

        }
    }
}
