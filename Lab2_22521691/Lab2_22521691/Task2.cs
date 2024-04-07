using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_22521691
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
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

        private int[] Count(StreamReader read)
        {
            string data = read.ReadToEnd();
            int lineCount = 1, wordCount = 0, charCount = data.Length;

            if (data[0] != ' ') wordCount = 1;
            for (int i = 0; i < charCount; i++)
            {
                if (i + 1 < charCount && (data[i] == ' ' || data[i] == '\n') && data[i + 1] != ' ' && data[i + 1] != '\n')
                {
                    wordCount++;
                    if (data[i] == '\n') lineCount++;
                }
            }
            return new int[] {lineCount, wordCount, charCount};
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Văn bản(.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFile.SafeFileName;

                fileURL.Text = openFile.FileName;

                StreamReader read = new StreamReader(fileURL.Text);
                

                fileSize.Text = read.BaseStream.Length.ToString() + " bytes";

                int[] count = Count(read);
                fileLineCount.Text = count[0].ToString();
                fileWordCount.Text = count[1].ToString();
                fileCharCount.Text = count[2].ToString();
                read.Close();

                StreamReader readAg = new StreamReader(fileURL.Text);
                fileData.Text = readAg.ReadToEnd();
                readAg.Close();
            }
        }
    }
}
