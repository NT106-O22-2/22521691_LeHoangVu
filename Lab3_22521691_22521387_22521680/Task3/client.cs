using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class client : Form
    {

        NetworkStream ns;
        Thread receiveThread;
        public client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient = new TcpClient();
        private void ConnectBt_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);
                ConnectBt.Enabled = false;
                ns = tcpClient.GetStream();
                receiveThread = new Thread(ReceiveData);
                receiveThread.Start();
            }
            catch
            {
                MessageBox.Show("Không kết nối được với server.");
            }
        }

        private void SendBT_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                Byte[] data = Encoding.ASCII.GetBytes(messageTb.Text);
                ns.Write(data, 0, data.Length);
                messageTb.Clear();
            }
            else
            {
                MessageBox.Show("Kết nối tới server đã đóng.");
            }
        }

        private void DisconnectBt_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                Byte[] data = Encoding.ASCII.GetBytes("Quit\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
                receiveThread.Abort();
            }
            else
            {
                MessageBox.Show("Kết nối tới server đã đóng.");
            }
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] receivedBytes = new byte[1024];
                    int byteCount = ns.Read(receivedBytes, 0, receivedBytes.Length);
                    string receivedData = Encoding.ASCII.GetString(receivedBytes, 0, byteCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu: " + ex.Message);
            }
        }
    }
}
