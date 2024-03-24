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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void exit_button(object sender, EventArgs e)
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
            Regex regex = new Regex("^[0-9]$");
            if (regex.IsMatch(input.Text))
            {
                switch (Convert.ToInt32(input.Text))
                {
                    case 0:
                        result.Text = "Không";
                        break;
                    case 1:
                        result.Text = "Một";
                        break;
                    case 2:
                        result.Text = "Hai";
                        break;
                    case 3:
                        result.Text = "Ba";
                        break;
                    case 4:
                        result.Text = "Bốn";
                        break;
                    case 5:
                        result.Text = "Năm";
                        break;
                    case 6:
                        result.Text = "Sáu";
                        break;
                    case 7:
                        result.Text = "Bảy";
                        break;
                    case 8:
                        result.Text = "Tám";
                        break;
                    default:
                        result.Text = "Chín";
                        break;
                }
            }
            else MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            result.Clear();
            input.Clear();
        }

        private void load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(50, 0, 0, 0);
            label2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
    }
}
