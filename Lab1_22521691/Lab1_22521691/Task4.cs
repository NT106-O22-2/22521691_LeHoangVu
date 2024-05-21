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
    public partial class Task4 : Form
    {
        string[] nums = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        string[] units = { "", "Mươi", "Trăm", "Nghìn", "Triệu", "Tỷ" };
        public Task4()
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

        private void read_clicked(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]\\d*$");
            if (regex.IsMatch(input.Text))
            {
                string text = input.Text;
                string resultTxt = "";
                string reverseNum = "";
                if (text.Length <= 12)
                {
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        reverseNum += text[i];
                    }
                    for (int i = 0; i < reverseNum.Length; i++)
                    {
                        if (reverseNum[i] == '0' && resultTxt == "") { }  //Spam 0 thì vẫn nhận kết quả là 0
                        else
                        {
                            if (reverseNum[i] == '0')
                            {
                                if (i == 2)
                                    resultTxt = "Không Trăm " + resultTxt;
                                else if (i % 3 == 1 && (reverseNum[i + 1] != '0' || i == 1))
                                    resultTxt = "Lẻ " + resultTxt;
                                else if (i % 3 == 0)
                                {
                                    switch (i / 3)
                                    {
                                        case 1:
                                            resultTxt = "Nghìn " + resultTxt;
                                            break;
                                        case 2:
                                            resultTxt = "Triệu " + resultTxt;
                                            break;
                                        case 3:
                                            resultTxt = "Tỷ " + resultTxt;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                if (i % 3 == 1)
                                {
                                    if (reverseNum[i] != '1')
                                        resultTxt = "Mươi " + resultTxt;
                                    else
                                    {
                                        resultTxt = "Mười " + resultTxt;
                                        continue;
                                    }

                                }
                                else if (i % 3 == 2)
                                    resultTxt = "Trăm " + resultTxt;
                                else if (i % 3 == 0)
                                {
                                    switch (i / 3)
                                    {
                                        case 1:
                                            resultTxt = "Nghìn " + resultTxt;
                                            break;
                                        case 2:
                                            resultTxt = "Triệu " + resultTxt;
                                            break;
                                        case 3:
                                            resultTxt = "Tỷ " + resultTxt;
                                            break;
                                    }
                                }
                                resultTxt = nums[(int)reverseNum[i] - 48] + " " + resultTxt;
                            }
                        }
                    }
                    if (resultTxt != "")
                        resultLB.Text = resultTxt;
                    else resultLB.Text = "Không";
                }
                else MessageBox.Show("Vui lòng nhập số nguyên dưới 12 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            input.Clear();
            resultLB.Text = "";
        }

        private void load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(50, 0, 0, 0);
            label2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
    }
}
