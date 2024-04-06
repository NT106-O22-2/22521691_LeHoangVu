using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_22521691
{
    public partial class Task6 : Form
    {
        //Lưu đường dẫn dtb
        string dataPath = "task6.db";

        SQLiteDataReader rd;

        private void Data_Show()
        {
            var con = new SQLiteConnection();
            con.Open();

            string stm = "SELECT * FROM task6";
            var cmd = new SQLiteCommand(stm, con);
            rd = cmd.ExecuteReader();
        }

        private void Create_DTB()
        {
            if (!System.IO.File.Exists(dataPath))
            {
                SQLiteConnection.CreateFile(dataPath);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
                {
                    sqlite.Open();
                    string tbMonAn = "CREATE TABLE MonAn (IDMonAn INTEGER PRIMARY KEY AUTOINCREMENT, TenMonAn TEXT, HinhAnh BLOB, IDNCC TEXT)";

                    SQLiteCommand command = new SQLiteCommand(tbMonAn, sqlite);
                    command.ExecuteNonQuery();

                    string tbNgCung = "CREATE TABLE NguoiDung(IDNCC TEXT PRIMARY KEY, HoVaTen VARCHAR(30), QuyenHan VARCHAR(10) DEFAULT 'Người cung cấp');";

                    command = new SQLiteCommand(tbNgCung, sqlite);
                    command.ExecuteNonQuery();


                    sqlite.Close();
                }
            } else
            {
                Console.WriteLine("Database can't create");
                return;
            }
        }

        private void Task6_Load(object sender, EventArgs e)
        {
            Create_DTB();
        }

        public Task6()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void browPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Hình ảnh|*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picPath.Text = openFile.FileName;
                browPicBtn.Hide();
            }
        }

        private string Name_Valid(string name)
        {
            Regex checkName = new Regex("^([A-ZĂÂÁẤẮÀẦẰẢẨẲÃẪẴẠẬẶÔƠÒỒỜÓỐỚỎỔỞÕỖỠỌỘỢÊÈỀÉẾẺỂẼỄẸỆỲÝỶỸỴÌÍỈĨỊÙÚỦŨỤ]([a-zăâáấắàầằảẩẳãẫẴạậặôơòồờóốớỏổởõỗỠọộợêèềéếẻểẽễẹệỳýỷỹỵìíỉĩịùúủũụ]*|)([ ]|$))+$");  //Kiểm tra tên nhập vào có hợp lệ không
            if (checkName.IsMatch(name))
                return name; 
            throw new Exception("Định dạng tên không hợp lệ!!!");
        }

        private void ID_Valid(string ID)    //Kiểm tra ID có bị trùng không
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();
                string sql = "SELECT EXISTS (SELECT * FROM NguoiDung WHERE IDNCC = @ID)";

                using (var command = new SQLiteCommand(sql, sqlite))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    if (Convert.ToBoolean(command.ExecuteScalar()))
                        throw new Exception("ID người cung cấp bị trùng!!!");
                }
            }
        }

        private void Find_ID_Match(string ID)   //Kiểm tra ID có tồn tại không
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();
                string sql = "SELECT EXISTS (SELECT * FROM NguoiDung WHERE IDNCC = @ID)";

                using (var command = new SQLiteCommand(sql, sqlite))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    if (!Convert.ToBoolean(command.ExecuteScalar()))
                        throw new Exception("ID người cung cấp bị trùng!!!");
                }
            }
        }

        private void Food_Valid(string food)    //Kiểm tra tên món có trùng không
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();

                string sql = "SELECT EXISTS (SELECT * FROM MonAn WHERE TenMonAn = @TM)";

                using (var command = new SQLiteCommand(sql, sqlite))
                {
                    command.Parameters.AddWithValue("@TM", food);
                    bool isDup = Convert.ToBoolean(command.ExecuteScalar());
                    if (isDup) { throw new Exception("Tên món ăn bị trùng!!!"); }
                        
                }
            }
        }

        private void Path_Valid(string path)
        {
            if (path == "")
                throw new Exception("Cần chèn ảnh!!!");
        }

        private void addProviBtn_Click(object sender, EventArgs e)
        {
            string name;
            try
            {
                name = Name_Valid(addName.Text);
                ID_Valid(addID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();
                string sql = "INSERT INTO NguoiDung (IDNCC, HoVaTen) VALUES (@IDNCC, @HoVaTen)";

                using (var command = new SQLiteCommand(sql, sqlite))
                {
                    command.Parameters.AddWithValue("@IDNCC", addID.Text);
                    command.Parameters.AddWithValue("@HoVaTen", name);
                    //Thực thi
                    command.ExecuteNonQuery();

                    MessageBox.Show("Người dùng đã được thêm!", "Thông báo", MessageBoxButtons.OK);

                    addID.Text = "";
                    addName.Text = "";
                }
            }

        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Food_Valid(insertFoodName.Text);
                Find_ID_Match(insertID.Text);
                Path_Valid(picPath.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imgPath = picPath.Text;
            byte[] imageBytes = File.ReadAllBytes(imgPath);

            //Thêm dữ liệu món
            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();
                string sql = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDCC)";

                using (var command = new SQLiteCommand(sql, sqlite))
                {
                    command.Parameters.AddWithValue("@TenMonAn", insertFoodName.Text);
                    command.Parameters.AddWithValue("@HinhAnh", imageBytes);
                    command.Parameters.AddWithValue("@IDCC", insertID.Text);

                    //Thực thi
                    command.ExecuteNonQuery();
                }
            }


            browPicBtn.Show();
            picPath.Text = "";
            insertFoodName.Text = "";
            insertID.Text = "";
        }

        private void findFoodBtn_Click(object sender, EventArgs e)
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + dataPath))
            {
                sqlite.Open();
                string sqlCount = "SELECT COUNT(*) FROM MonAn";
                using (var commandCount = new SQLiteCommand(sqlCount, sqlite))
                {
                    int count = Convert.ToInt32(commandCount.ExecuteScalar());

                    // Nếu không có bản ghi nào, trả về null
                    if (count == 0)
                        return;

                    Random random = new Random();
                    int randomNumber = random.Next(count) + 1;

                    // Lấy đường dẫn ảnh theo số ngẫu nhiên
                    string sqlGetImage = "SELECT HinhAnh, TenMonAn, IDNCC FROM MonAn WHERE IDMonAn = @Id";
                    using (var getCmd = new SQLiteCommand(sqlGetImage, sqlite))
                    {
                        getCmd.Parameters.AddWithValue("@Id", randomNumber);

                        using (var reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["HinhAnh"];
                                foodPic.Image = Image.FromStream(new MemoryStream(imageBytes));

                                
                                string nameFood = (string)reader["TenMonAn"];
                                providerName.Text = nameFood;
                                string providerID = (string)reader["IDNCC"];
                                string sql = "SELECT HoVaTen FROM NguoiDung WHERE IDNCC = @ID";

                                using (var command = new SQLiteCommand(sql, sqlite))
                                {
                                    command.Parameters.AddWithValue("@ID", providerID);

                                    using (var reader2 = command.ExecuteReader())
                                    {
                                        if (reader2.Read())
                                        {
                                            providerName.Text  += ", đóng góp: " + (string)reader2["HoVaTen"];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void delFoodBtn_Click(object sender, EventArgs e)
        {
            browPicBtn.Show();
            insertFoodName.Text = "";
            insertID.Text = "";
            picPath.Text = "";
        }
    }
}
