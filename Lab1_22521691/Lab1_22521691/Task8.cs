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
    public partial class Task8 : Form
    {
        public Task8()
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
            insertLB.BackColor = Color.FromArgb(50, 0, 0, 0);
            inforLB.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            inforLB.Refresh();
            insertTB.Clear();
        }
        private bool valid_name(string name)
        {
            Regex checkName = new Regex("^([A-ZĂÂÁẤẮÀẦẰẢẨẲÃẪẴẠẬẶÔƠÒỒỜÓỐỚỎỔỞÕỖỠỌỘỢÊÈỀÉẾẺỂẼỄẸỆỲÝỶỸỴÌÍỈĨỊÙÚỦŨỤ]([a-zăâáấắàầằảẩẳãẫẴạậặôơòồờóốớỏổởõỗỠọộợêèềéếẻểẽễẹệỳýỷỹỵìíỉĩịùúủũụ]*|)([ ]|$))+$");  //Kiểm tra tên nhập vào có hợp lệ không
            if (checkName.IsMatch(name)) return true;
            return false;
        }
        private void insert_clicked(object sender, EventArgs e)
        {
            string[] data = insertTB.Text.Split(',');
            float[] score = new float[data.Length - 1];
            string result = "Họ và tên: ";
            if (data.Length >= 2) 
            {
                if (valid_name(data[0]))
                {
                    result += data[0] + "\n";
                    for (int i = 1; i < data.Length; i++)
                    {
                        Regex checkNum = new Regex("^[0-9]+(\\.[0-9]+)?$");
                        data[i] = data[i].Trim();
                        if (checkNum.IsMatch(data[i]) && Convert.ToSingle(data[i]) <= 10)
                        {
                            score[i - 1] = Convert.ToSingle(data[i]);
                            result += "Môn " + i + ": " + score[i - 1] + "      ";
                            if (score[i - 1] != 10) result += " ";
                            if (i % 3 == 0) result += "\n";
                        } else
                        {
                            MessageBox.Show("Điểm nhập vào không trong thang điểm 10!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    inforLB.Text = result;
                } else MessageBox.Show("Tên nhập vào không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Dữ liệu nhập vào cần ít nhất họ tên và \nđiểm số của một môn học!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
