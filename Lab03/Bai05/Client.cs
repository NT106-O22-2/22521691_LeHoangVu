using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Client : Form
    {
        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 12345;

        public Client()
        {
            InitializeComponent();
        }

        private void btnGuiDuLieu_Click(object sender, EventArgs e)
        {
            SendDataToServer();
        }


        private async void SendDataToServer()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(ServerIP, ServerPort);
                    NetworkStream? stream = client.GetStream();

                    if (stream != null)
                    {
                        StreamWriter? writer = new StreamWriter(stream);

                        // Gửi dữ liệu trước với header "Data"
                        string data = "Data,MonAn," + txtTenMonAn.Text + "," + txtTenNguoiDung.Text;
                        if (writer != null)
                        {
                            await writer.WriteLineAsync(data);
                            await writer.FlushAsync();

                            StreamReader? reader = new StreamReader(stream);
                            if (reader != null)
                            {
                                string? response = await reader.ReadLineAsync();
                                if (response != null && response == "Data received successfully")
                                {
                                    // gửi ảnh với header "Image"
                                    writer.WriteLine("Image");
                                    await writer.FlushAsync();

                                    byte[] imageBytes = File.ReadAllBytes(txtHinhAnhName.Text);
                                    await stream.WriteAsync(imageBytes, 0, imageBytes.Length);
                                    await stream.FlushAsync();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Hình ảnh|*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnhName.Text = openFile.FileName;
                btnAnh.Hide();
            }
        }
    }
}
