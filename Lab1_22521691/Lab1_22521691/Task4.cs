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
        public Task4()
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

        private void read_clicked(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[1-9]\\d*$");
            if(regex.IsMatch(input.Text))
            {
                string text = input.Text;
                string resultTxt = "";
                if (text.Length <= 12)
                {
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        if (i == 0 && text[0] == '0') { /*Nếu số ban đầu là 0 thì không đọc số đó*/ }
                        else
                        {
                            int num = text[i] - 48;
                            switch (num)
                            {
                                case 0:
                                    resultTxt = "Không " + resultTxt;
                                    break;
                                case 1:
                                    resultTxt = "Một " + resultTxt;
                                    break;
                                case 2:
                                    resultTxt = "Hai " + resultTxt;
                                    break;
                                case 3:
                                    resultTxt = "Ba " + resultTxt;
                                    break;
                                case 4:
                                    resultTxt = "Bốn " + resultTxt;
                                    break;
                                case 5:
                                    resultTxt = "Năm " + resultTxt;
                                    break;
                                case 6:
                                    resultTxt = "Sáu " + resultTxt;
                                    break;
                                case 7:
                                    resultTxt = "Bảy " + resultTxt;
                                    break;
                                case 8:
                                    resultTxt = "Tám " + resultTxt;
                                    break;
                                case 9:
                                    resultTxt = "Chín " + resultTxt;
                                    break;
                            }

                            switch (i)
                            {
                                case 3:
                                    resultTxt = "Nghìn " + resultTxt;
                                    break;
                                case 6:
                                    resultTxt = "Triệu " + resultTxt;
                                    break;
                                case 9:
                                    resultTxt = "Tỷ " + resultTxt;
                                    break;
                            }
                        }
                     }
                    resultTxt = resultTxt.Substring(0, resultTxt.Length - 1);
                    result.Text = resultTxt;
                } else MessageBox.Show("Vui lòng nhập số nguyên dưới 12 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Vui lòng nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            input.Clear();
            result.Clear();
        }
    }
}
