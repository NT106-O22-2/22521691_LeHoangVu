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

namespace sever1
{
    public partial class sever : Form
    {

        private Socket serverSocket;
        private ListBox logListBox = new ListBox();
        private Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        private List<string> globalRoom = new List<string>();  //Danh sách room tổng
        private Dictionary<string, List<string>> chatRooms = new Dictionary<string, List<string>>();
        private object locker = new object();
        public sever()
        {
            InitializeComponent();
            InitializeLogListBox();
        }
        private void InitializeLogListBox()
        {
            logListBox.Dock = DockStyle.Fill;
            Controls.Add(logListBox);
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            StartServerButton.Enabled = false;
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 8888));
            serverSocket.Listen(10);
            AddLog("Server started...");

            Thread listenThread = new Thread(ListenForClients);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    Thread clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                AddLog("Error: " + ex.Message);
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesReceived = clientSocket.Receive(buffer);
                string clientName = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                lock (locker)
                {
                    clients.Add(clientName, clientSocket);
                    globalRoom.Add(clientName); //thêm client vào globalRoom
                }

                AddLog($"{clientName} connected.");

                while (true)
                {
                    buffer = new byte[1024];
                    bytesReceived = clientSocket.Receive(buffer);
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);



                    // Nếu thông điệp bắt đầu từ chữ join thì lập tức yêu cầu tạo phòng chat cụ thể
                    if (message.StartsWith("/join"))
                    {
                        //tách chữ join và tên phòng chat
                        string[] parts = message.Split(' ');
                        if (parts.Length == 2)
                        {
                            string roomName = parts[1];
                            lock (locker)
                            {
                                //Kiểm tra phòng chat đã tồn tại chưa
                                if (!chatRooms.ContainsKey(roomName))
                                {
                                    chatRooms.Add(roomName, new List<string>());
                                }
                                chatRooms[roomName].Add(clientName);
                            }
                            //Gửi thông điệp vào phòng chat thành công
                            SendMessageToClient(clientSocket, $"Joined room '{roomName}'");
                        }
                        else
                        {
                            SendMessageToClient(clientSocket, "Invalid command. Usage: /join [roomName]");
                        }
                    }
                    else
                    {
                        // Check if client is in a specific room
                        bool isInRoom = false;
                        string room = null;
                        lock (locker)
                        {
                            foreach (var chatRoom in chatRooms)
                            {
                                // Nếu tên khách hàng có trong danh sách thành viên của một phòng chat
                                if (chatRoom.Value.Contains(clientName))
                                {
                                    isInRoom = true;
                                    room = chatRoom.Key;
                                    break;
                                }
                            }
                        }

                        // Nếu khách hàng đang tham gia một phòng chat cụ thể
                        if (isInRoom)
                        {
                            lock (locker)
                            {
                                foreach (var member in chatRooms[room])
                                {
                                    clients[member].Send(Encoding.ASCII.GetBytes($"{clientName}: {message}"));
                                }
                            }
                            // Ghi lại thông điệp vào hộp thoại log
                            AddLog($"{clientName}({room}): {message}");
                        }
                        else
                        {
                            lock (locker)
                            {
                                foreach (var member in globalRoom)
                                {
                                    clients[member].Send(Encoding.ASCII.GetBytes($"{clientName}: {message}"));
                                }
                            }
                            AddLog($"{clientName}(Global): {message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddLog("Error: " + ex.Message);
            }
        }

        private void SendMessageToClient(Socket clientSocket, string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            clientSocket.Send(buffer);
        }

        private void AddLog(string log)
        {
            if (logListBox.InvokeRequired)
            {
                logListBox.Invoke(new Action<string>(AddLog), log);
            }
            else
            {
                logListBox.Items.Add(log);
            }
        }
    }
}

