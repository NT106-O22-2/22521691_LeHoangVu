using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client1
{
    public partial class client : Form
    {
        private Socket clientSocket;
        private string clientName;
        public client()
        {
            InitializeComponent();
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectButton.Enabled = false;
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect("127.0.0.1", 8888);

            clientName = NameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientSocket.Send(Encoding.ASCII.GetBytes(clientName));

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text.Trim();
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientSocket.Send(Encoding.ASCII.GetBytes(message));
            MessageTextBox.Text = "";
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = RoomNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(roomName))
            {
                MessageBox.Show("Please enter a room name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string request = $"/join {roomName}";
            clientSocket.Send(Encoding.ASCII.GetBytes(request));
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesReceived = clientSocket.Receive(buffer);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                    // Add code here to update UI with received message
                    UpdateChatBox(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChatBox(string message)
        {
            if (chatListBox.InvokeRequired)
            {
                chatListBox.Invoke(new Action<string>(UpdateChatBox), message);
            }
            else
            {
                chatListBox.Items.Add(message);
            }
        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

