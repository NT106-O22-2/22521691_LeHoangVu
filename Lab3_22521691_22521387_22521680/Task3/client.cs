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
                DisconnectBt.Enabled = true;
                SendBT.Enabled = true;
                ns = tcpClient.GetStream();
                Byte[] data = Encoding.ASCII.GetBytes("Hello\n");
                ns.Write(data, 0, data.Length);
            }
            catch
            {
                MessageBox.Show("Không kết nối được với server.");
            }
        }

        private void SendBT_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected && messageTb.Text !="")
            {
                Byte[] data = Encoding.ASCII.GetBytes("client send: " + messageTb.Text + "\n");
                ns.Write(data, 0, data.Length);
                messageTb.Clear();
            }
            else if (messageTb.Text == "")
            {
                MessageBox.Show("Vui long nhap noi dung");
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
                ConnectBt.Enabled = true;
                DisconnectBt.Enabled = false;
                SendBT.Enabled = false;
                ns.Close();
                tcpClient.Close();
            }
            else
            {
                MessageBox.Show("Kết nối tới server đã đóng.");
            }
        }
    }
}
