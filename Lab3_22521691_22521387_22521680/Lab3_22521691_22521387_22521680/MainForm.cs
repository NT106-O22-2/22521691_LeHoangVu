using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_22521691_22521387_22521680
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void task1Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task1 t1 = new Task1();
            t1.ShowDialog();
            this.Close();
        }

        private void task2Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task2 t2 = new Task2();
            t2.ShowDialog();
            this.Close();
        }

        private void task3Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task3 t3 = new Task3();
            t3.ShowDialog();
            this.Close();
        }

        private void task4Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task4 t4 = new Task4();
            t4.ShowDialog();
            this.Close();
        }

        private void task5Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task5 t5 = new Task5();
            t5.ShowDialog();
            this.Close();
        }

        private void task6Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task6 t6 = new Task6();
            t6.ShowDialog();
            this.Close();
        }
    }
}
