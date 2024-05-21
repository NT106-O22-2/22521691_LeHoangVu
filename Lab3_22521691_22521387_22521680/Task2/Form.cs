using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task2
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool isRunning;
        Socket clientSocket;
        Socket listenerSocket;
        IPEndPoint ipServer;
        public Form()
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

        private void listenBtn_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(Start_Unsafe_Thread));
            serverThread.Start();
        }

        void Start_Unsafe_Thread()
        {
            try
            {
                if (!isRunning)
                {
                    isRunning = true;
                    int bytesRecv = 0;
                    byte[] recv = new byte[1];
                    MessageBox.Show("Server is running", "Notification", MessageBoxButtons.OK);

                    listenerSocket.Bind(ipServer);
                    listenerSocket.Listen(-1);
                    clientSocket = listenerSocket.Accept();


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
                }
                else
                    MessageBox.Show("Server has already been opened", "Notification", MessageBoxButtons.OK);
            } catch
            {
                listenerSocket.Close();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            listenerSocket.Close();
        }
    }
}
