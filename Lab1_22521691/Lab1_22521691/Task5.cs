using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_22521691


{
    public partial class buyBtn : Form
    {
        public buyBtn()
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

        private void Task5_Load(object sender, EventArgs e)
        {
            inforLabel.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void findRoom(object sender, EventArgs e)
        {
            
        }

        private void film_choose(object sender, EventArgs e)
        {
            string selectedValue = movieCB.Text.ToString();
            switch (selectedValue)
            {
                case ("Đào, phở và piano"):
                    roomCB.DataSource = new List<int> { 1, 2, 3 };
                    roomCB.SelectedIndex = -1;

                    inforLabel.Text = "Vé VIP: 90.000đ\n" +
                                      "Vé thường: 45.000đ\n" +
                                      "Vé vớt: 11.250đ";
                    break;
                case ("Mai"):
                    roomCB.DataSource = new List<int> { 2, 3 };
                    roomCB.SelectedIndex = -1;
                    break;
                case ("Gặp lại chị bầu"):
                    roomCB.DataSource = new List<int> { 1 };
                    roomCB.SelectedIndex = -1;
                    break;
                case ("Tarot"):
                    roomCB.DataSource = new List<int> { 3 };
                    roomCB.SelectedIndex = -1;
                    break;
            }
            movieCB.Refresh();

          
        }
    }
}
