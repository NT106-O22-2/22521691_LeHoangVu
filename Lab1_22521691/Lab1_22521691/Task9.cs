using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22521691
{
    public partial class Task9 : Form
    {
        private string foodList = "";
        private int foodCount = 0;
        public Task9()
        {
            InitializeComponent();
        }

        private void load(object sender, EventArgs e)
        {
            insertLB.BackColor = Color.FromArgb(50, 0, 0, 0);
            inforLB.BackColor = Color.FromArgb(150, 0, 0, 0);
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
            inforLB.Refresh();
            insertTB.Clear();
        }

        private void insertFood(object sender, EventArgs e)
        {
            if (insertTB.Text != "")
            {
                if (foodList != "")
                    foodList = "\n" + foodList;
                foodList = insertTB.Text + foodList;
                foodCount++;
                inforLB.Text = foodList;
            } else MessageBox.Show("Không nhận thấy tên món ăn?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void find_food(object sender, EventArgs e)
        {
            if (foodList != "") {
                Random random = new Random();
                int foodNumber = random.Next(foodCount - 1);
                string finalFood = "";
                int lineDownCount = 0;
                for (int i = 0; i < foodList.Length; i++)
                {
                    if (foodList[i] == '\n')
                    {
                        lineDownCount++;
                        continue;
                    }
                    if (lineDownCount > foodNumber)
                        break;
                    else if (lineDownCount == foodNumber)
                        finalFood += foodList[i];
                }
                
                resultTB.Text = finalFood;
                MessageBox.Show("Món ăn hôm nay là " + finalFood, "Chúc mừng", MessageBoxButtons.OK);
            } else MessageBox.Show("Hiện không có món ăn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
