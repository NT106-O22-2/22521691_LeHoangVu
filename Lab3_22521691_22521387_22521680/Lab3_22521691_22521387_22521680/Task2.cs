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

namespace Lab3_22521691_22521387_22521680
{
    public partial class Task2 : Form
    {
        bool isRunning;
        Socket clientSocket;
        Socket listenerSocket;
        IPEndPoint ipServer;
        public Task2()
        {
            InitializeComponent();
            isRunning = false;
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(Start_Unsafe_Thread));
            serverThread.Start();
        }

        void Start_Unsafe_Thread()
        {
            if (!isRunning)
            {
                isRunning = true;
                int bytesRecv = 0;
                byte[] recv = new byte[1];

                listenerSocket.Bind(ipServer);
                listenerSocket.Listen(-1);
                clientSocket = listenerSocket.Accept();

                MessageBox.Show("Server is running", "Notification", MessageBoxButtons.OK);

                dataLv.Items.Add(new ListViewItem(Text = DateTime.Now.ToString("HH:mm:ss") + ": New client connected!!!"));
                while (clientSocket.Connected)
                {
                    string txt = "";
                    do
                    {
                        bytesRecv = clientSocket.Receive(recv);
                        txt += Encoding.ASCII.GetString(recv);
                    } while (txt[txt.Length - 1] != '\n');
                    dataLv.Items.Add(new ListViewItem(txt));
                }

                listenerSocket.Close();
            } else
                MessageBox.Show("Server has already been opened", "Notification", MessageBoxButtons.OK);
        }

        private void Task2_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Socket client in clientSocket)
            {

            }
            listenerSocket.Close();
        }
    }
}
