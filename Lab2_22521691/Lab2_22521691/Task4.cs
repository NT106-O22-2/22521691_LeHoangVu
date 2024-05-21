using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static AngouriMath.Entity.Number;

namespace Lab2_22521691
{
    public partial class Task4 : Form
    {
        List<string> allID;
        string inputFile, outputFile;
        public Task4()
        {
            InitializeComponent();
            allID = new List<string>();
            inputFile = "input4.txt";
            outputFile = "output4.txt";
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

        private void Name_Valid(string name)
        {
            Regex checkName = new Regex("^([A-ZĂÂÁẤẮÀẦẰẢẨẲÃẪẴẠẬẶÔƠÒỒỜÓỐỚỎỔỞÕỖỠỌỘỢÊÈỀÉẾẺỂẼỄẸỆỲÝỶỸỴÌÍỈĨỊÙÚỦŨỤ]([a-zăâáấắàầằảẩẳãẫẴạậặôơòồờóốớỏổởõỗỠọộợêèềéếẻểẽễẹệỳýỷỹỵìíỉĩịùúủũụ]*|)([ ]|$))+$");  //Kiểm tra tên nhập vào có hợp lệ không
            if (checkName.IsMatch(name))
                return;
            throw new Exception("Định dạng tên không hợp lệ!!!");
        }

        private void Id_Valid(string id)
        {
            Regex checkID = new Regex("^[0-9]+$");
            if (checkID.IsMatch(id) && id.Length == 8)
            {
                if (allID != null)
                {
                    for (int i = 0; i < allID.Count; i++)
                    {
                        if (allID[i] == id)
                            throw new Exception("MSSV bị trùng!!!");
                    }
                }
                allID.Add(id);
            }
            else throw new Exception("Định dạng ID không hợp lệ!!!");
        }

        private void Phone_Valid(string phone)
        {
            Regex checkPhone = new Regex("^0(?:\\d{9}|[1-9]\\d{8})$");
            if (checkPhone.IsMatch(phone))
                return;
            throw new Exception("Định dạng số điện thoại sai!!!");
        }

        private void Course_Valid(string score)
        {
            Regex checkScore = new Regex("^[0-9]+$");
            if (checkScore.IsMatch(score) && Convert.ToInt32(score) >= 0 && Convert.ToInt32(score) <= 10)
                return;
            throw new Exception("Điểm nhập vào phải >= 0 và <= 10");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string dataAdd = "";
            try
            {
                Name_Valid(nameWrite.Text);
                dataAdd += nameWrite.Text + "\n";

                Id_Valid(idWrite.Text);
                dataAdd += idWrite.Text + "\n";

                Phone_Valid(phoneWrite.Text);
                dataAdd += phoneWrite.Text + "\n";

                Course_Valid(course1Write.Text);
                dataAdd += course1Write.Text + "\n";

                Course_Valid(course2Write.Text);
                dataAdd += course2Write.Text + "\n";

                Course_Valid(course3Write.Text);
                dataAdd += course3Write.Text + "\n";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            dataLB.Text += dataAdd + "\n";
            MessageBox.Show("Sinh viên đã được thêm", "Thông báo", MessageBoxButtons.OK);

            nameWrite.Clear();
            idWrite.Clear();
            phoneWrite.Clear();
            course1Write.Clear();
            course2Write.Clear();
            course3Write.Clear();
        }

        private void writeFileBtn_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter(inputFile);
            write.WriteLine(dataLB.Text);
            MessageBox.Show("Dữ liệu đã được viết!!!", "Thông báo", MessageBoxButtons.OK);
            write.Close();
        }

        List<string> studentList = new List<string>();
        private void readFileBtn_Click(object sender, EventArgs e)
        {
            studentList.Clear();
            StreamReader read = new StreamReader(inputFile);
            string data = read.ReadToEnd();
            string[] arr = data.Split('\n');
            data = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 7 == 6)     //Thêm điểm trung bình vào
                    data += ((float.Parse(arr[i - 3]) + float.Parse(arr[i - 2]) + float.Parse(arr[i - 1])) / 3).ToString() + "\n";
                data += arr[i] + "\n";
            }

            StreamWriter write = new StreamWriter(outputFile);
            write.WriteLine(data);

            if (arr.Length >= 7)    //Hiển thị dữ liệu sinh viên đầu tiên
            {
                nameRead.Text = arr[0];
                idRead.Text = arr[1];
                phoneRead.Text = arr[2];
                course1Read.Text = arr[3];
                course2Read.Text = arr[4];
                course3Read.Text = arr[5];
                avgRead.Text = ((float.Parse(arr[3]) + float.Parse(arr[4]) + float.Parse(arr[5])) / 3).ToString();
                pageNum.Text = "1";
            }

            //Thêm dữ liệu vào studentList
            studentList.AddRange(data.Split('\n'));

            read.Close();
            write.Close();
        }

        private void Appear_Data(int newPageNum)
        {
            nameRead.Text = studentList[0 + (newPageNum - 1) * 8];
            idRead.Text = studentList[1 + (newPageNum - 1) * 8];
            phoneRead.Text = studentList[2 + (newPageNum - 1) * 8];
            course1Read.Text = studentList[3 + (newPageNum - 1) * 8];
            course2Read.Text = studentList[4 + (newPageNum - 1) * 8];
            course3Read.Text = studentList[5 + (newPageNum - 1) * 8];
            avgRead.Text = studentList[6 + (newPageNum - 1) * 8];
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (pageNum.Text == "1")
            {
                MessageBox.Show("Dữ liệu không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int newPageNum = Convert.ToInt32(pageNum.Text) - 1;
            pageNum.Text = newPageNum.ToString();

            Appear_Data(newPageNum);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int newPageNum = Convert.ToInt32(pageNum.Text) + 1;
            if (newPageNum * 8 >= studentList.Count)
            {
                MessageBox.Show("Dữ liệu đã hết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pageNum.Text = newPageNum.ToString();

            Appear_Data(newPageNum);
        }
    }
}
