using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace Lab2_22521691
{
    public partial class Task3 : Form
    {
        StreamReader input;
        StreamWriter output;
        public Task3()
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

        private void Task3_Load(object sender, EventArgs e)
        {

        }

        private double result_Cal(string lineData)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (lineData == "" && regex.IsMatch(lineData[0].ToString()))
                throw new Exception("Lỗi định dạng!");

            double result;
            if (double.TryParse(lineData, out result))
                return result;
            else
                throw new Exception("Lỗi định dạng");
        }

        void reCallInput()
        {
            input = new StreamReader("D:\\UIT\\Nam_2\\HK2\\Lập trình mạng căn bản - NT106.O22\\Lab\\22521691_LeHoangVu\\Lab2_22521691\\Lab2_22521691\\bin\\Debug\\input3.txt");
        }
        void reCallOutput()
        {
            try
            {
                output = new StreamWriter("D:\\UIT\\Nam_2\\HK2\\Lập trình mạng căn bản - NT106.O22\\Lab\\22521691_LeHoangVu\\Lab2_22521691\\Lab2_22521691\\bin\\Debug\\output3.txt");
            } catch
            {
                return;
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            reCallInput();
            reCallOutput();
            string inputText = input.ReadToEnd();
            string[] calculation = inputText.Split('\n');
            string result = "";

            reCallInput();
            for (int i = 0; i < calculation.Length; i++)
            {
                try
                {
                    result += calculation[i] + " = " + result_Cal(calculation[i]).ToString() + "\n";
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            inputData.Text = inputText;
            output.WriteLine(result);
            outputData.Text = result;

            input.Close();
            output.Close();
        }
    }
}
