using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521691
{
    public partial class Task7 : Form
    {
        private string[] zodiac = ["Ma Kết", "Bảo Bình", "Song Ngư", "Bạch Dương",
                                   "Kim Ngưu", "Song Tử", "Cự Giải", "Sư Tử",
                                   "Xử Nữ", "Thiên Bình", "Thần Nông", "Nhân Mã"];
        private string zodiacInfor = "22/12 - 20/01: Ma Kết\n21/01 - 19/02: Bảo Bình\n"
                                     + "20/02 - 20/03: Song Ngư\n21/03 - 20/04: Bạch Dương\n"
                                     + "21/04 - 21/05: Kim Ngưu\n22/05 - 21/06: Song Tử\n"
                                     + "22/06 - 22/07: Cự Giải\n23/07 - 22/08: Sư Tử\n"
                                     + "23/08 - 23/09: Xử Nữ\n24/09 - 23/10: Thiên Bình\n"
                                     + "24/10 - 22/11: Thần Nông\n23/11 - 21/12: Nhân Mã";
        public Task7()
        {
            InitializeComponent();
        }

        private void exit_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 255, 255, 255);
            inforLB.BackColor = Color.FromArgb(100, 0, 0, 0);
            inforLB.Text = zodiacInfor;
            inforLB.BorderStyle = BorderStyle.FixedSingle;
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            inputTB.Clear();
        }

        private int born_check(string input)
        {
            //1: dữ liệu đúng
            //0: ngày k hợp lệ
            //-1: sai format
            if (input.Length != 10) return -1;
            Regex regex = new Regex("^[0-9]$");
            if (regex.IsMatch(input[0].ToString()) && regex.IsMatch(input[1].ToString()) && (input[2] == '/' || input[2] == '-') &&
                regex.IsMatch(input[3].ToString()) && regex.IsMatch(input[4].ToString()) && (input[5] == '/' || input[5] == '-') &&
                regex.IsMatch(input[6].ToString()) && regex.IsMatch(input[7].ToString()) && 
                regex.IsMatch(input[8].ToString()) && regex.IsMatch(input[9].ToString()))
            {
                int day = Convert.ToInt32(input[0].ToString() + input[1].ToString());
                if (day < 0 || day > 31) return 0;

                int month = Convert.ToInt32(input[3].ToString() + input[4].ToString());
                if (month <= 0 || month > 12) return 0;

                int year = Convert.ToInt32(input[6].ToString() + input[7].ToString() + input[8].ToString() + input[9].ToString());
                if (year < 1900 || year > 2024) return 0;

                if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30) return 0;

                if (month == 2 && ((day > 28 && year % 4 != 0) || ((day > 29 && year % 4 == 0)))) return 0;
            }
            else return -1;
            return 1;
        }

        

        private void check_clicked(object sender, EventArgs e)
        {
            int index = born_check(inputTB.Text);
            if (index == 1) 
            {
                String input = inputTB.Text;
                String result = "";
                int day = Convert.ToInt32(input[0].ToString() + input[1].ToString());
                int month = Convert.ToInt32(input[3].ToString() + input[4].ToString());
                if ((day >= 22 && month == 12) || (day <= 20 && month == 1))
                    result = zodiac[0];
                else if ((day >= 21 && month == 1) || (day <= 19 && month == 2))
                    result = zodiac[1];
                else if ((day >= 20 && month == 2) || (day <= 20 && month == 3))
                    result = zodiac[2];
                else if ((day >= 21 && month == 3) || (day <= 20 && month == 4))
                    result = zodiac[3];
                else if ((day >= 21 && month == 4) || (day <= 21 && month == 5))
                    result = zodiac[4];
                else if ((day >= 22 && month == 5) || (day <= 21 && month == 6))
                    result = zodiac[5];
                else if ((day >= 22 && month == 6) || (day <= 22 && month == 7))
                    result = zodiac[6];
                else if ((day >= 23 && month == 7) || (day <= 22 && month == 8))
                    result = zodiac[7];
                else if ((day >= 23 && month == 8) || (day <= 23 && month == 9))
                    result = zodiac[8];
                else if ((day >= 24 && month == 9) || (day <= 23 && month == 10))
                    result = zodiac[9];
                else if ((day >= 24 && month == 10) || (day <= 22 && month == 11))
                    result = zodiac[10];
                else result = zodiac[11];

                MessageBox.Show("Cung của bạn là " + result, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else if (index == 0)
                        MessageBox.Show("Ngày không hợp lệ!!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   else if (index == -1)
                   MessageBox.Show("Vui lòng nhập với kiểu DD/MM/YYY hoặc DD-MM-YYYY", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
