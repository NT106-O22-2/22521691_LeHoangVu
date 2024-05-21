using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521691
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void switch_Task1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task1 t1 = new Task1();
            t1.ShowDialog();
            this.Close();
        }

        private void switch_Task2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Task2 t2 = new Task2();
            t2.ShowDialog();
            this.Close();
        }

        private void switch_Task3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Task3 t3 = new Task3();
            t3.ShowDialog();
            this.Close();
        }

        private void switch_Task4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Task4 t4 = new Task4();
            t4.ShowDialog();
            this.Close();
        }

        private void switch_Task5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Task5 t5 = new Task5();
            t5.ShowDialog();
            this.Close();
        }

        private void switch_Task6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Task6 t6 = new Task6();
            t6.ShowDialog();
            this.Close();
        }

        private void switch_Task7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task7 t7 = new Task7();
            t7.ShowDialog();
            this.Close();
        }
    }
}
