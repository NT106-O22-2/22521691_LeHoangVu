using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab2_22521691
{

    public partial class Task5 : Form
    {
        int[] yLocate = { 220, 292, 364};
        int[] xLocate = { 377, 449, 521, 593, 665 };
        System.Windows.Forms.Button[,] seats = new System.Windows.Forms.Button[3, 5];
        Dictionary<string, seatBuy> room = new Dictionary<string, seatBuy>();
        seatBuy[] allRoom; //Lưu dữ liệu tất cả các phòng

        seatBuy currentRoom;

        string inputJson;
        List<Movie> movies;

        string outputJson;
        List<MovieInfor> shows;
        public Task5()
        {
            InitializeComponent();
            inputJson = File.ReadAllText("input5.json");
            outputJson = File.ReadAllText("output5.json");
            shows = JsonConvert.DeserializeObject<List<MovieInfor>>(outputJson);

            movies = JsonConvert.DeserializeObject<List<Movie>>(inputJson);

            int totalRooms = 0;
            int curRoom = 0;
            foreach (Movie movie in movies)
            {
                totalRooms += movie.room.Length;
                movieCB.Items.Add(movie.name);  //Lấy tên từng phim
            }
            allRoom = new seatBuy[totalRooms];

            foreach (Movie movie in movies)
                for (int i = 0; i < movie.room.Length; i++)
                {
                    room.Add(movie.name + (i + 1).ToString(), allRoom[curRoom] = new seatBuy(movie.standardTicket, movie.name));
                    curRoom++;
                }
        }

        private void Task5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                {
                    //Tạo button
                    seats[i, j] = new System.Windows.Forms.Button();
                    seats[i, j].Text = (j + 1).ToString();
                    string nameSeats = "seats[" + i + ", " + j + "]";
                    seats[i, j].Name = nameSeats;
                    seats[i, j].Location = new Point(xLocate[j], yLocate[i]);
                    seats[i, j].Size = new Size(60, 60);
                    seats[i, j].Font = new Font("UTM Avo", 20, FontStyle.Bold);
                    seats[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    seats[i, j].BackColor = Color.White;
                    seats[i, j].FlatStyle = FlatStyle.Flat;
                    seats[i, j].FlatAppearance.BorderSize = 0;
                    Controls.Add(seats[i, j]);
                    seats[i, j].BringToFront();
                    seats[i, j].Hide();
                    seats[i, j].Click += Seats_Clicked;
                }
        }

        private void Seats_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            string input = clickedButton.Name;  //Lấy nút đã bấm
            int x = Int32.Parse(input[6].ToString());
            int y = Int32.Parse(input[9].ToString());

            if (!currentRoom.get_state(x, y))
            {
                bool duplicate = false;

                if (ticketBuy.Text != "")
                {
                    string[] split = ticketBuy.Text.Split(',');
                    for (int i = 0; i < split.Length - 1; i++)
                        if (x == Convert.ToInt32(split[i][0]) - 65 && y == Convert.ToInt32(split[i][1]) - 48)        //Tránh trường hợp tick 1 ô 2 lần
                            duplicate = true;
                }

                if (!duplicate)
                {
                    ticketBuy.Text += (char)(x + 65) + y.ToString() + ",";
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
                        ticketBuy.Text = "";
                    }
                }
            }
            else MessageBox.Show("Chỗ đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Choose_Film(object sender, EventArgs e)
        {
            string selectedValue = movieCB.Text.ToString();
            //Lấy phòng của từng phim
            List<int> rooms = new List<int>();
            int price = 0;

            roomCB.Items.Clear();
            roomCB.Text = "";
            foreach (Movie movie in movies)
                if (string.Compare(movie.name, selectedValue, true) == 0)
                {
                    foreach (int room in movie.room)
                    {
                        roomCB.Items.Add(room);
                    }
                    roomCB.SelectedIndex = -1;
                    price = movie.standardTicket;
                    break;
                }

            inforLB.Text = "Vé VIP: " + (price * 2).ToString() + "\n" +
                           "Vé thường: " + price.ToString() + "\n" +
                           "Vé vớt: " + (price / 4).ToString();
            movieCB.Refresh();
            roomCB.Refresh();
        }

        private void findRoomBtn_Click(object sender, EventArgs e)
        {
            if (movieCB.Text != "" && roomCB.Text != "")
            {
                string key = movieCB.Text;
                key += roomCB.Text;
                currentRoom = room[key];
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (currentRoom.get_state(i, j))
                            seats[i, j].BackColor = Color.Gray;
                        else seats[i, j].BackColor = Color.White;
                        if (!seats[i, j].Visible) seats[i, j].Show();
                    }
            }
            else MessageBox.Show("Hãy chọn phim và phòng chiếu trước khi chọn chỗ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (ticketBuy.Text != "" && insertName.Text != "")
            {
                string[] split = ticketBuy.Text.Split(',');
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
                string infor = "Khách hàng: " + insertName.Text + "\nVé đã chọn: " + ticketBuy.Text + "\nTên phim: " + movieCB.Text + "\nPhòng chiếu số: " + roomCB.Text + "\nThành tiền: " + totalPrice.Text;
                MessageBox.Show(infor, "Chúc quý khách xem phim vui vẻ <3", MessageBoxButtons.OK);
                
                foreach (MovieInfor movieIf in shows)
                {
                    if (movieIf.name == movieCB.Text)
                    {   //Xử lý file ouput
                        movieIf.exitsTicket -= split.Length;
                        movieIf.soldTicket += split.Length;
                        movieIf.percentSold = (((double)movieIf.exitsTicket) / movieIf.soldTicket).ToString() + "%";
                        movieIf.revenue += Convert.ToInt32(totalPrice.Text);
                    }
                }

                //Cập nhật rank
                int[] rankList = { shows[0].revenue, shows[1].revenue, shows[2].revenue, shows[3].revenue };
                int[] rankIndex = new int[rankList.Length];
                var sortedList = rankList.OrderByDescending(x => x).Select((x, i) => new { Rank = i + 1, Value = x });

                foreach (var item in sortedList)
                {
                    rankIndex[item.Rank - 1] = item.Value;
                }

                int k = 0;
                foreach (MovieInfor movieIf in shows)
                {
                    movieIf.rank = rankIndex[k];
                    k++;
                }

                insertName.Clear();
                ticketBuy.Clear();
                totalPrice.Text = "0";
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void filmDataBtn_Click(object sender, EventArgs e)
        {
            foreach (MovieInfor movie in shows)
            {
                if (movieCB.Text ==  movie.name)
                {
                    movieDataLB.Text = "Tên phim: " + movie.name + "\nVé đã bán: "
                        + movie.soldTicket + "  Còn lại: " + movie.exitsTicket + "\nTỷ lệ bán: "
                        + movie.percentSold + "\nDoanh thu: " + movie.revenue + "đ\nXếp hạng tại rạp: " + movie.rank;
                    return;
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            insertName.Clear();
            ticketBuy.Clear();
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
