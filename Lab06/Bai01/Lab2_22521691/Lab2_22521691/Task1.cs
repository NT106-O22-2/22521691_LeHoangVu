using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521691
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }


        private void readFileBtn_Click(object sender, EventArgs e)
        {
            fileData.Clear();
            try
            {
                StreamReader read = new StreamReader("input1.txt");
                fileData.Text = read.ReadToEnd();
                read.Close();
            } catch 
            {
                MessageBox.Show("File không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeFileBtn_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("output1.txt");
            fileData.Text = fileData.Text.ToUpper();
            write.WriteLine(fileData.Text);
            write.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            fileData.Clear();
        }
    }
}
