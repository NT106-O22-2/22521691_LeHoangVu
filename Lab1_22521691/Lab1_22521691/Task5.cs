using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab1_22521691
{

    public partial class buyBtn : Form
    {
        int[] yLocate = { 326, 396, 466, 536, 606 };
        int[] xLocate = { 109, 192, 275, 358, 441 };
        System.Windows.Forms.Button[,] seats = new System.Windows.Forms.Button[3, 5];
        Dictionary<string, seatBuy> room = new Dictionary<string, seatBuy>();
        seatBuy[] allRoom = new seatBuy[7];

        seatBuy firstAppear = new seatBuy("");
        seatBuy currentRoom;

        //System.Windows.Forms.Button[,] seats = new System.Windows.Forms.Button[3, 5];
        public buyBtn()
        {
            InitializeComponent();
            room.Add("Đào, phở và piano1", allRoom[0] = new seatBuy("Đào, phở và piano"));
            room.Add("Đào, phở và piano2", allRoom[1] = new seatBuy("Đào, phở và piano"));
            room.Add("Đào, phở và piano3", allRoom[2] = new seatBuy("Đào, phở và piano"));
            room.Add("Mai2", allRoom[3] = new seatBuy("Mai"));
            room.Add("Mai3", allRoom[4] = new seatBuy("Mai"));
            room.Add("Gặp lại chị bầu1", allRoom[5] = new seatBuy("Gặp lại chị bầu"));
            room.Add("Tarot3", allRoom[6] = new seatBuy("Tarot"));
        }

        private void exit_clicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Close();
            }
        }

        private void load(object sender, EventArgs e)
        {
            inforLabel.BackColor = Color.FromArgb(150, 0, 0, 0);
            backGrLb.BackColor = Color.FromArgb(150, 0, 0, 0);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                {
                    seats[i, j] = new System.Windows.Forms.Button();
                    seats[i, j].Text = (j + 1).ToString();
                    string nameSeats = "seats[" + i + ", " + j + "]";
                    seats[i, j].Name = nameSeats;
                    seats[i, j].Location = new Point(yLocate[j], xLocate[i]);
                    seats[i, j].Size = new Size(63, 63);
                    seats[i, j].Font = new Font("Times New Roman", 32, FontStyle.Bold);
                    seats[i, j].TextAlign = ContentAlignment.TopCenter;
                    seats[i, j].BackColor = Color.White;
                    Controls.Add(seats[i, j]);
                    seats[i, j].BringToFront();
                    seats[i, j].Click += seats_clicked;
                }
        }
        private void seats_clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            string input = clickedButton.Name;
            int x = Int32.Parse(input[6].ToString());
            int y = Int32.Parse(input[9].ToString());
            
            if (!currentRoom.get_state(x, y))
            {
                bool duplicate = false;

                if (ticket.Text != "")
                {
                    string[] split = ticket.Text.Split(", ");
                    for (int i = 0; i < split.Length - 1; i++)
                    {
                        if (x == Convert.ToInt32(split[i][0]) - 65 && y == Convert.ToInt32(split[i][1]) - 48)        //Tránh trường hợp tick 1 ô 2 lần
                            duplicate = true;

                    }
                }
                if (!duplicate) {
                    ticket.Text += (char)(x + 65) + y.ToString() + ", ";
                    if (currentRoom != null)
                    {
                        seats[x, y].BackColor = Color.Orange;
                        int a = Int32.Parse(totalPrice.Text) + currentRoom.get_price(x, y);
                        totalPrice.Text = a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn phim và phòng chiếu trước khi chọn chỗ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        totalPrice.Text = "";
                        ticket.Text = "";
                    }
                }
            }
            else MessageBox.Show("Chỗ đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    inforLabel.Text = "Vé VIP: 200.000đ\n" +
                                      "Vé thường: 100.000đ\n" +
                                      "Vé vớt: 25.000đ";
                    break;
                case ("Gặp lại chị bầu"):
                    roomCB.DataSource = new List<int> { 1 };
                    roomCB.SelectedIndex = -1;

                    inforLabel.Text = "Vé VIP: 140.000đ\n" +
                                      "Vé thường: 70.000đ\n" +
                                      "Vé vớt: 17.500đ";
                    break;
                case ("Tarot"):
                    roomCB.DataSource = new List<int> { 3 };
                    roomCB.SelectedIndex = -1;

                    inforLabel.Text = "Vé VIP: 180.000đ\n" +
                                      "Vé thường: 90.000đ\n" +
                                      "Vé vớt: 22.500đ";
                    break;
            }
            movieCB.Refresh();
            roomCB.Refresh();
        }

        private void find_room_clicked(object sender, EventArgs e)
        {
            if (movieCB.Text != "" && roomCB.Text != "")
            {
                string key = movieCB.Text;
                key += roomCB.Text;
                currentRoom = room[key];
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 5; j++)
                        if (currentRoom.get_state(i, j))
                            seats[i, j].BackColor = Color.Gray;
                        else seats[i, j].BackColor = Color.White;
            }
            else MessageBox.Show("Hãy chọn phim và phòng chiếu trước khi chọn chỗ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buy_clicked(object sender, EventArgs e)
        {
            if (ticket.Text != "" && name.Text != "")
            {
                string[] split = ticket.Text.Split(", ");
                for (int i = 0; i < split.Length - 1; i++)
                {
                    int x = Convert.ToInt32(split[i][0]) - 65;
                    int y = Convert.ToInt32(split[i][1]) - 48;
                    currentRoom.set_state(x, y, true);
                }
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 5; j++)
                        if (currentRoom.get_state(i, j))
                            seats[i, j].BackColor = Color.Gray;
                        else seats[i, j].BackColor = Color.White;
                string infor = "Khách hàng: " + name.Text + "\nVé đã chọn: " + ticket.Text + "\nTên phim: " + movieCB.Text + "\nPhòng chiếu số: " + roomCB.Text + "\nThành tiền: " + totalPrice.Text;
                MessageBox.Show(infor, "Chúc quý khách xem phim vui vẻ <3", MessageBoxButtons.OK);
                name.Clear();
                ticket.Clear();
                totalPrice.Text = "0";
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void delete_clicked(object sender, EventArgs e)
        {
            name.Clear();
            ticket.Clear();
            totalPrice.Text = "0";
            if (currentRoom != null)
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    if (currentRoom.get_state(i, j))
                        seats[i, j].BackColor = Color.Gray;
                    else seats[i, j].BackColor = Color.White;
        }
    }
}
