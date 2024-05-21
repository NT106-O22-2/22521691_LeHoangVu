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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task3
{
    public partial class sever : Form
    {
        public sever()
        {
            InitializeComponent();
        }

        private void Receive(Socket clientSocket)
        {
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    byte[] buffer = new byte[1];
                    clientSocket.Receive(buffer);
                    text += Encoding.UTF8.GetString(buffer);
                } while (text[text.Length - 1] != '\n');

                if (messageLv.InvokeRequired)
                {
                    messageLv.Invoke((MethodInvoker)delegate
                    {
                        messageLv.Items.Add(text);
                    });
                }
            }
        }

        private void StartServer() {
            Socket listener = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            listener.Bind(ipEndPoint);
            listener.Listen(10);
            while(true)
            {
                Socket clientSocket = listener.Accept();
                Thread thread = new Thread(() => Receive(clientSocket));
				thread.Start();
            }
        }
        private void StartBt_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Thread thread = new Thread(StartServer);
            thread.Start();
        }
    }
}
