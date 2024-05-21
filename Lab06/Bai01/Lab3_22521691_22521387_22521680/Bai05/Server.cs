using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai05
{
    public partial class Server : Form
    {
        private const string connectionString = "Data Source=food.db";

        private TcpListener? server;
        private bool isRunning;

        public Server()
        {
            CreateDatabase();
            //InsertDatabase();
            InitializeComponent();
        }
        private void CreateDatabase()
        {
            if (!File.Exists("food.db"))
            {
                SQLiteConnection.CreateFile("food.db");

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createMonAn = @"CREATE TABLE IF NOT EXISTS MonAn (
                                      IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                      TenMonAn TEXT,
                                      HinhAnh BLOB,
                                      IDNCC INTEGER,
                                      FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                                      )";
                    using (SQLiteCommand command = new SQLiteCommand(createMonAn, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    string createNguoiDung = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                                          IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                          HoVaTen TEXT,
                                          QuyenHan TEXT
                                          )";
                    using (SQLiteCommand command = new SQLiteCommand(createNguoiDung, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
        }

        public class DatabaseHelper
        {
            public static void InsertMonAn(string tenMonAn, string hinhAnhName, int idNCC)
            {
                byte[] imageData = Array.Empty<byte>();
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        //byte[] imageData = File.ReadAllBytes(hinhAnh);
                        Image? image = (Image?)Properties.Resources.ResourceManager.GetObject(hinhAnhName);
                        if (image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imageData = ms.ToArray();
                            }
                        }

                        command.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        command.Parameters.AddWithValue("@HinhAnh", imageData);
                        command.Parameters.AddWithValue("@IDNCC", idNCC);
                        command.ExecuteNonQuery();
                    }
                }
            }
            public static void InsertNguoiDung(string hoVaTen, string quyenHan)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, @QuyenHan)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                        command.Parameters.AddWithValue("@QuyenHan", quyenHan);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void InsertDatabase()
        {
            DatabaseHelper.InsertMonAn("Jollibee", "Jollibee", 1);
            DatabaseHelper.InsertNguoiDung("Nguyễn Hồng Duyên", "admin");

            DatabaseHelper.InsertMonAn("Bún bò", "bun_bo", 2);
            DatabaseHelper.InsertNguoiDung("Đặng Vĩnh Hội", "user");

            DatabaseHelper.InsertMonAn("Bún đậu mắm tôm", "bun_dau", 3);
            DatabaseHelper.InsertNguoiDung("Nguyễn Hữu Tài", "user");

            DatabaseHelper.InsertMonAn("Cơm tấm", "com_tam", 4);
            DatabaseHelper.InsertNguoiDung("Ngô Nguyễn Minh Mẫn", "admin");

            DatabaseHelper.InsertMonAn("Mì cay", "mi_cay", 5);
            DatabaseHelper.InsertNguoiDung("Phạm Thị Thanh Vinh", "user");

            DatabaseHelper.InsertMonAn("Phở", "pho", 1);
            DatabaseHelper.InsertMonAn("Bánh mì", "banh_mi", 2);
            DatabaseHelper.InsertMonAn("Gà nướng", "ga_nuong", 3);
            DatabaseHelper.InsertMonAn("Bún riêu", "bun_rieu", 4);
            DatabaseHelper.InsertMonAn("Hủ tiếu", "hu_tieu", 5);
        }

        private void btnXemDSMonAn_Click(object sender, EventArgs e)
        {
            ShowDSMon();
        }

        private void btnXemDSNCC_Click(object sender, EventArgs e)
        {
            ShowDSNguoi();
        }

        void ShowDSMon()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM MonAn";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        lsvDSMonan.Items.Clear();
                        while (reader.Read())
                        {
                            string id = reader.GetInt32(0).ToString();
                            string ten = reader.GetString(1);
                            //string hinhAnh = reader.GetString(2);
                            string hinhAnhPath = reader.GetString(2);
                            string idNCC = reader.GetInt32(3).ToString();

                            // Tạo ListViewItem và thêm vào listViewDSMon
                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(ten);

                            byte[] imageBytes = (byte[])reader["HinhAnh"];
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }
                            item.Tag = image;
                            item.SubItems.Add("Image");

                            // item.SubItems.Add(hinhAnhPath); // Đây là đường dẫn đến hình ảnh, bạn có thể hiển thị nó trong control phù hợp.

                            item.SubItems.Add(idNCC);
                            lsvDSMonan.Items.Add(item);


                        }
                    }
                }
            }
        }

        void ShowDSNguoi()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM NguoiDung";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        lsvDSNCC.Items.Clear();
                        while (reader.Read())
                        {
                            string id = reader.GetInt32(0).ToString();
                            string hoVaTen = reader.GetString(1);
                            string quyenHan = reader.GetString(2);

                            // Tạo ListViewItem và thêm vào listViewDSNguoi
                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(hoVaTen);
                            item.SubItems.Add(quyenHan);

                            lsvDSNCC.Items.Add(item);

                        }
                    }
                }
            }

        }

        private void lsvDSMonan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSMonan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvDSMonan.SelectedItems[0];

                if (selectedItem.Tag is Image image)
                {
                    PictureBox.Image = image;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private async void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 12345);
                server.Start();
                isRunning = true;
                AppendLog("Server started...");
                await Task.Run(() => ListenForClients());
            }
            catch (Exception ex)
            {
                AppendLog($"Error starting server: {ex.Message}");
            }
        }

        private async Task ListenForClients()
        {
            while (isRunning)
            {
                TcpClient client = await server!.AcceptTcpClientAsync();
                await Task.Run(() => HandleClient(client));
            }
        }


        private async void HandleClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);

                string? data = await reader.ReadLineAsync();

                if (data != null)
                {
                    ProcessData(data, stream);

                    // Gọi hàm để lưu dữ liệu vào cơ sở dữ liệu
                    await SaveDataToDatabase(data);
                }
                writer.WriteLine("Data received and processed successfully.");
                writer.Flush();

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                AppendLog($"Error handling client: {ex.Message}");
            }
        }

        private async Task SaveDataToDatabase(string data)
        {
            // Phân tích dữ liệu từ chuỗi nhận được
            string[] parts = data.Split(',');
            if (parts.Length >= 4)
            {
                string monAnTen = parts[1];
                string nguoiTen = parts[2];
                string imageBase64 = parts[3];

                // Giải mã dữ liệu ảnh từ chuỗi Base64
                byte[] imageBytes = Convert.FromBase64String(imageBase64);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Insert dữ liệu vào bảng MonAn
                    string insertMonAn = @"INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";
                    using (SQLiteCommand commandMonAn = new SQLiteCommand(insertMonAn, connection))
                    {
                        commandMonAn.Parameters.AddWithValue("@TenMonAn", monAnTen);
                        commandMonAn.Parameters.AddWithValue("@HinhAnh", imageBytes);
                        commandMonAn.Parameters.AddWithValue("@IDNCC", GetNguoiDungIdByName(nguoiTen));

                        await commandMonAn.ExecuteNonQueryAsync();
                    }
                    // Kiểm tra xem người dùng đã tồn tại trong bảng NguoiDung chưa
                    int nguoiDungId = GetNguoiDungIdByName(nguoiTen);
                   
                    {
                        int maxId;
                        string queryMaxId = "SELECT MAX(IDNCC) FROM NguoiDung";
                        using (SQLiteCommand commandMaxId = new SQLiteCommand(queryMaxId, connection))
                        {
                            Task<object?> taskMaxId = commandMaxId.ExecuteScalarAsync();
                            taskMaxId.Wait(); // Đợi hoàn thành
                            object? maxIdResult = taskMaxId.Result;
                            maxId = (maxIdResult != null && maxIdResult != DBNull.Value) ? Convert.ToInt32(maxIdResult) : 0;
                        }
                        // Nếu người dùng chưa tồn tại, thêm mới vào bảng NguoiDung
                        if (nguoiDungId == maxId + 1)
                        {
                            string insertNguoiDung = @"INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, @QuyenHan)";
                            using (SQLiteCommand commandNguoiDung = new SQLiteCommand(insertNguoiDung, connection))
                            {
                                commandNguoiDung.Parameters.AddWithValue("@IDNCC", nguoiDungId);
                                commandNguoiDung.Parameters.AddWithValue("@HoVaTen", nguoiTen);
                                commandNguoiDung.Parameters.AddWithValue("@QuyenHan", "User");

                                await commandNguoiDung.ExecuteNonQueryAsync();
                            }
                        }
                        
                    }
                    connection.Close();

                    // Hiển thị lại danh sách món ăn và danh sách người dùng sau khi lưu dữ liệu thành công
                    ShowDSMon();
                    ShowDSNguoi();

                }

            }
        }

        private int GetNguoiDungIdByName(string nguoiTen)
        {
            int nguoiId = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string queryNguoi = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @HoVaTen";
                using (SQLiteCommand commandNguoi = new SQLiteCommand(queryNguoi, connection))
                {
                    commandNguoi.Parameters.AddWithValue("@HoVaTen", nguoiTen);

                    Task<object?> task = commandNguoi.ExecuteScalarAsync();
                    task.Wait(); // Đợi hoàn thành
                    object? result = task.Result;
                    //object result = commandNguoi.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out nguoiId))
                    {
                        nguoiId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Nếu không tìm thấy tên người dùng, đặt nguoiId bằng id lớn nhất trong bản người dùng + 1
                        string queryMaxId = "SELECT MAX(IDNCC) FROM NguoiDung";
                        using (SQLiteCommand commandMaxId = new SQLiteCommand(queryMaxId, connection))
                        {
                            Task<object?> taskMaxId = commandMaxId.ExecuteScalarAsync();
                            taskMaxId.Wait(); // Đợi hoàn thành
                            object? maxIdResult = taskMaxId.Result;
                            int maxId = (maxIdResult != null && maxIdResult != DBNull.Value) ? Convert.ToInt32(maxIdResult) : 0;
                            nguoiId = maxId + 1;
                        }
                    }
                }
                connection.Close();
            }
            return nguoiId;
        }

        private void ProcessData(string? data, NetworkStream stream)
        {
            if (data != null)
            {
                string[] parts = data.Split(',');
                if (parts.Length <= 3 && parts[0] == "MonAn")
                {
                    string tenMonAn = parts[1];
                    int idNCC = int.Parse(parts[2]);
                    byte[] imageData = ReadImageDataFromStream(stream);
                    string imageName = GenerateImageName();
                    string imagePath = SaveImageToFile(imageName, imageData);

                    DatabaseHelper.InsertMonAn(tenMonAn, imagePath, idNCC);
                }
                else
                {
                    AppendLog("Invalid data format.");
                }
            }
        }

        private string GenerateImageName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
        }

        private string SaveImageToFile(string fileName, byte[] imageData)
        {
            // Lưu dữ liệu hình ảnh vào thư mục tạm thời trên máy chủ
            string directoryPath = "TempImages";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, fileName);
            File.WriteAllBytes(filePath, imageData);
            return filePath;
        }

        private byte[] ReadImageDataFromStream(NetworkStream stream)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, bytesRead);
                }
                return ms.ToArray();
            }
        }

        private void AppendLog(string message)
        {
            using (StreamWriter writer = File.AppendText("server_log.txt"))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        private void StopServer()
        {
            try
            {
                server!.Stop();
                isRunning = false;
                AppendLog("Server stopped.");
            }
            catch (Exception ex)
            {
                AppendLog($"Error stopping server: {ex.Message}");
            }
        }
       
    }
}
