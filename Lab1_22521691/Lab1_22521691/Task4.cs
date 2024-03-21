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
            MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
            this.Close();
        }

        private void read_clicked(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]\\d*$");
            if(regex.IsMatch(input.Text))
            {
                string text = input.Text;
                string resultTxt = "";
                if (text.Length <= 12)
                {
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        if (text[i] == '0' && i == 0) {
                            /*Nếu số ban đầu là 0 thì không đọc số đó*/
                            if (text.Length == 1)
                            {   //Trường hợp chỉ nhập số 0
                                resultTxt = "Không";
                                result.Text = resultTxt;
                                return;
                            }
                        }
                        else
                        {
                            int num = text[i] - 48;
                            String numCr = nums[num];
                            String unitCr = units[text.Length - i - 1];
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
