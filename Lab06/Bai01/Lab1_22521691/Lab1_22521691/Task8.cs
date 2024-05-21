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
        string[] rank = { "Xuất sắc", "Giỏi", "Khá", "Trung bình", "Yếu", "Kém" };
        public Task8()
        {
            InitializeComponent();
        }

        private void exit_clicked(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
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
            bool[] pass = new bool[data.Length - 1];
            string result = "Họ và tên: ";

            float avarage = 0, maxSc = 0, minSc = 0;
            string maxRel = "", minRel = "";

            string passSub = "Các môn đậu: ";
            string nPassSub = "Các môn trượt: ";
            bool passExits = false, nPassExits = false;
            int constraintRank = 1; //biến này để xác định xem có môn ràng buộc kéo danh hiệu xuống

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
                            if (score[i - 1] < 2 && constraintRank < 6) constraintRank = 6;
                            else if (score[i - 1] < 3.5 && constraintRank < 5) constraintRank = 5;
                            else if (score[i - 1] < 5 && constraintRank < 4) constraintRank = 4;
                            else if (score[i - 1] < 6.5 && constraintRank < 3) constraintRank = 3;
                            else if (score[i - 1] < 8 && constraintRank < 2) constraintRank = 2;

                            result += "Môn " + i + ": " + score[i - 1] + "      ";
                            if (score[i - 1] != 10) result += " ";
                            if (i % 3 == 0 && i != data.Length - 1) result += "\n";

                            if (i == 1) minSc = score[i - 1];
                            if (score[i - 1] > maxSc)
                            {
                                maxSc = score[i - 1];
                                maxRel = "Môn có điểm cao nhất:  Môn " + i + ": " + score[i - 1] + " điểm";

                            }
                            else if (score[i - 1] == maxSc) maxRel += ", Môn" + i + ": " + score[i - 1] + " điểm";

                            if (score[i - 1] < minSc)
                            {
                                minSc = score[i - 1];
                                minRel = "Môn có điểm thấp nhất:  Môn " + i + ": " + score[i - 1] + " điểm";
                            }
                            else if (score[i - 1] == minSc) minRel += ", Môn " + i + ": " + score[i - 1] + " điểm";

                            avarage += score[i - 1];
                            if (score[i - 1] >= 5)
                            {
                                passSub += "Môn " + i + ", ";
                                passExits = true;
                            }
                            else
                            {
                                nPassSub += "Môn " + i + ", ";
                                nPassExits = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Điểm nhập vào không trong thang điểm 10!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    avarage /= (data.Length - 1);
                    result += "\n" + "Điểm trung bình: " + avarage + "\n" + maxRel + "\n" + minRel + "\n";

                    if (passExits) passSub = passSub.Substring(0, passSub.Length - 2);      //Xóa ", "
                    else passSub += "Không có";
                    if (nPassExits) nPassSub = nPassSub.Substring(0, nPassSub.Length - 2);
                    else nPassSub += "Không có";



                    result += passSub + "\n" + nPassSub + "\n" + "Sinh viên xếp loại: ";
                    result += rank[constraintRank - 1];
                    inforLB.Text = result;
                }
                else MessageBox.Show("Tên nhập vào không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Dữ liệu nhập vào cần ít nhất họ tên và \nđiểm số của một môn học!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
