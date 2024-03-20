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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void exit_button(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void caculate_button(object sender, EventArgs e)
        {

            if (Regex.IsMatch(firstNum.Text, "^[-+]?[0-9]+$") && Regex.IsMatch(secondNum.Text, "^[-+]?[0-9]+$"))
            {   //Sử dụng regex để kiểm tra chuỗi có phải số nguyên không
                int first = Convert.ToInt32(firstNum.Text);
                int sec = Convert.ToInt32(secondNum.Text);
                int rel = first + sec;
                this.result.Text = rel.ToString();
            }
            else MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
