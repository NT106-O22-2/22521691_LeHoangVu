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
    public partial class Task6 : Form
    {
        public Task6()
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

        private void clear_clicked(object sender, EventArgs e)
        {
            firstNum.Clear();
            secondNum.Clear();
            inforCB.SelectedIndex = -1;
            resultLB.Text = "";
        }

        private void load(object sender, EventArgs e)
        {
            resultLB.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private string multiplication_table(int numA, int numB)
        {
            int numC = numB - numA;
            string result = "Ta có bảng cửu chương B - A = " + numC + ":\n";
            if (numB >= numA)
            {
                for (int i = 1; i <= 10; i++) 
                    result += numC + " * " + i + " = " + (numC * i) + "\n";
            }
            else result += "Không khả thi!";
            return result;
        }

        private string value_calculation(int numA, int numB)
        {
            string result = "(A - B)! = ";
            int numC = numA - numB;
            if (numC >= 0)
            {
                int numResult = 1;
                for (int i = 2; i < numC; i++)
                    numResult *= i;
                result += numResult;
            } else result += "Không khả thi!";
            result += "\n";
            result += "S = A^1 + A^2 + ... + A^B = ";
            int rsNum = 0;
            for (int i = 1; i <= numB; i++)
            {
                rsNum += (int)Math.Pow(numA, i);
            }
            result += rsNum;
            return result;
        }

        private void cal_clicked(object sender, EventArgs e)
        {
            Regex regex = new Regex("^\\d+$");
            if (regex.IsMatch(firstNum.Text) && regex.IsMatch(secondNum.Text)) 
            {
                int numA = Convert.ToInt32(firstNum.Text), numB = Convert.ToInt32(secondNum.Text);
                if (inforCB.Text == "Bảng cửu chương")
                {
                    resultLB.Text = multiplication_table(numA, numB);
                }
                if (inforCB.Text == "Tính toán giá trị")
                {
                    resultLB.Text = value_calculation(numA, numB);
                }
                if (inforCB.Text == "") {
                    MessageBox.Show("Vui lòng chọn loại phép tính",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } else MessageBox.Show("Vui lòng nhập vào 2 số nguyên dương",
                                   "Thông báo",
                                   MessageBoxButtons.OK, 
                                   MessageBoxIcon.Error);
        }
    }
}
