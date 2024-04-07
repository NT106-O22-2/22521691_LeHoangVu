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
using NaCl;


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


        StreamReader reCallInput()
        {
            return new StreamReader("input3.txt");
        }
        StreamWriter reCallOutput()
        {
            return new StreamWriter("output3.txt");
        }

        public Double Eval(String calculate)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToDouble(table.Compute(calculate, String.Empty));
            } catch
            {
                throw new Exception("Định dạng phép tĩnh " + calculate + " lỗi!!!");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            input = reCallInput();
            output = reCallOutput();
            string inputText = input.ReadToEnd();
            string[] calculation = inputText.Split('\n');
            string result = "";

            input = reCallInput();

            for (int i = 0; i < calculation.Length; i++)
            {
                try
                {
                    result += calculation[i] + " = " + Eval(calculation[i]).ToString() + "\n";
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            result = result.Replace("\r", "");

            inputData.Text = inputText;
            output.WriteLine(result);
            outputData.Text = result;

            input.Close();
            output.Close();
        }
    }
}
