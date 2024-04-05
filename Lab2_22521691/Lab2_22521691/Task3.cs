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

        private float result_Cal(string lineData)
        {
            float result;
            Regex regex = new Regex("[0-9]+$");
            if (lineData == "" && regex.IsMatch(lineData[0].ToString()))
                throw new Exception("Lỗi định dạng!");

            int i = 0;
            bool dot = false;
            string num = "";    //Lưu số
            char sign = '\0';        //Lưu phép tính

            while (lineData[i] != ' ' && lineData[i] != '\r')   //Kiểm tra số đầu tiên
            {
                if (regex.IsMatch(lineData[i].ToString()))
                    num += lineData[i];
                else if (lineData[i] == '.')
                    num += lineData[i];
                else throw new Exception("Lỗi định dạng!");
                i++;
            }
            result = float.Parse(num);
            num = "";

            float numConvert;
            while (i < lineData.Length - 1)     //Kiểm tra định dạng có đúng kiểu num1 <sign> num2 <sign> ... <sign> numN không 
            {
                if (regex.IsMatch(lineData[i].ToString()))
                    num += lineData[i];
                else if (lineData[i] == '.')
                    if (!dot)
                    {
                        num += lineData[i];
                        dot = true;
                    }
                    else throw new Exception("Lỗi định dạng!");
                else if (lineData[i] == ' ')
                {
                    if (sign != '\0')
                    {
                        numConvert = float.Parse(num);
                        switch(sign)
                        {
                            case '+':
                                result += numConvert; 
                                break;
                            case '-':
                                result -= numConvert;
                                break;
                            case '*':
                                result *= numConvert;
                                break;
                            case '/':
                                result /= numConvert;
                                break;
                        }
                        num = "";
                    }
                    if (lineData[i + 2] == ' ' && (lineData[i + 1] == '+' || lineData[i + 1] == '-' || lineData[i + 1] == '*' || lineData[i + 1] == '/'))
                    {
                        sign = lineData[i + 1];
                        dot = false;
                    }      
                    else throw new Exception("Lỗi định dạng!");
                    i += 2;
                }
                else throw new Exception("Lỗi định dạng!");
                i++;
            }

            //Thực hiện phép tính
            return result;
        }

        void reCallInput()
        {
            input = new StreamReader("input3.txt");
        }
        void reCallOutput()
        {
            try
            {
                output = new StreamWriter("output3.txt");
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
