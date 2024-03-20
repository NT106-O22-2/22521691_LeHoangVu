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
using static System.Net.Mime.MediaTypeNames;

namespace Lab1_22521691
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void exit_button(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void find_num(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[+-]?[0-9]+(\\.[0-9]+)?$");
            if (regex.IsMatch(firstNum.Text) &&  regex.IsMatch(secondNum.Text) && regex.IsMatch(thirdNum.Text) )
            {
                float num1 = Convert.ToSingle(firstNum.Text);
                float num2 = Convert.ToSingle(secondNum.Text);
                float num3 = Convert.ToSingle(thirdNum.Text);
                float min = num1, max = num2;

                if (min > num2) min = num2;
                else if (num2 > max) max = num2;

                if (min > num3) min = num3;
                else if (num3 > max) max = num3;

                this.maxNum.Text = max.ToString();
                this.minNum.Text = min.ToString();
            }
            else MessageBox.Show("Vui lòng nhập số thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void del_num(object sender, EventArgs e)
        {
            firstNum.Clear();
            secondNum.Clear();
            thirdNum.Clear();
            maxNum.Clear();
            minNum.Clear();
        }
    }
}
