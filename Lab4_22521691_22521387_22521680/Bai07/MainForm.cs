using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class MainForm : Form
    {
        private string access_token;

        public MainForm(string tokentype, string accesstoken)
        {
            InitializeComponent();
            this.access_token = $"{tokentype} {accesstoken}";

        }

        private JObject user = new JObject();
        private JToken danhSachMonAn;
        //private string access_token = "Bearer ";
        public static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private class Pagination
        {
            public int current { get; set; }
            public int pageSize { get; set; }
        }

        private Pagination pagination = new Pagination
        {
            current = 1,
            pageSize = 50
        };

        private async void GetDishes(bool myDishes = false)
        {
            string uri = myDishes ? "api/v1/monan/my-dishes" : "api/v1/monan/all";
            Panel panel = myDishes ? panelMyDished : panelAllDishes;
            panel.Controls.Clear();

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

            using HttpResponseMessage response = await httpClient.PostAsJsonAsync(
                uri,
                pagination
            );

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(keyValuePairs["detail"].ToString());
            }
            else
            {
                JToken paginationRes = keyValuePairs["pagination"];
                int total = paginationRes.Value<int>("total");
                double totalPage = Math.Ceiling((float)total / (float)pagination.pageSize);
                comboBoxPage.Items.Clear();
                for (int i = 1; i <= totalPage; i++)
                {
                    comboBoxPage.Items.Add(i);
                }
                danhSachMonAn = keyValuePairs["data"];
                DisplayMonAn(danhSachMonAn, panel);
                /*DisplayMonAn(keyValuePairs["data"], panel);*/
            }
        }
        private void DisplayMonAn(JToken dishes, Panel panel)
        {
            foreach (var dish in dishes)
            {
                Panel dishPanel = new Panel();
                dishPanel.Size = new Size(700, 200);
                dishPanel.BorderStyle = BorderStyle.FixedSingle;

                Label lbMonAn = new Label();
                lbMonAn.Text = dish.Value<string>("ten_mon_an");
                lbMonAn.Font = new Font("Segoe UI", 15F);
                lbMonAn.ForeColor = Color.Chocolate;
                lbMonAn.Size = new Size(300, 40);
                lbMonAn.Location = new Point(220, 10);
                dishPanel.Controls.Add(lbMonAn);

                Label lbGia = new Label();
                lbGia.Text = "Giá: " + dish.Value<float>("gia").ToString();
                lbGia.Location = new Point(220, 50);
                dishPanel.Controls.Add(lbGia);

                Label lbDiaChi = new Label();
                //lbDiaChi.Text = "Địa chỉ: " + dish.Value<string>("dia_chi").ToString();
                lbDiaChi.Text = "Địa chỉ: " + (dish["dia_chi"] != null ? dish.Value<string>("dia_chi") : "Không có thông tin");
                lbDiaChi.Location = new Point(220, 70);
                dishPanel.Controls.Add(lbDiaChi);

                Label lbNguoiDongGop = new Label();
                //lbNguoiDongGop.Text = "Đóng góp: " + dish.Value<string>("nguoi_dong_gop").ToString();
                lbNguoiDongGop.Text = "Đóng góp: " + (dish["nguoi_dong_gop"] != null ? dish.Value<string>("nguoi_dong_gop") : "Không có thông tin");
                lbNguoiDongGop.Location = new Point(220, 90);
                dishPanel.Controls.Add(lbNguoiDongGop);

                try
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(dish.Value<string>("hinh_anh"));
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    dishPanel.Controls.Add(pictureBox);
                }
                catch
                {
                    // Handle image load failure
                }

                Button btnDelete = new Button();
                btnDelete.Text = "Xóa";
                btnDelete.Tag = dish.Value<int>("id");
                btnDelete.Size = new Size(83, 45);
                btnDelete.Location = new Point(480, 150);
                btnDelete.Click += async (s, e) => await DeleteDish((int)btnDelete.Tag);
                dishPanel.Controls.Add(btnDelete);

                panel.Controls.Add(dishPanel);
            }
        }

        private async Task DeleteDish(int dishId)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/v1/monan/{dishId}");

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Xóa món ăn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDishes();
            }
            else
            {
                MessageBox.Show(keyValuePairs["detail"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAnGi_Click(object sender, EventArgs e)
        {
            /*int soMonAn = danhSachMonAn.ToArray().Length;
            var rand = new Random();
            int monAnIndex = rand.Next(soMonAn);
            var monan = danhSachMonAn.ElementAt(monAnIndex);

            ShowMonAn showMonAn = new ShowMonAn(monan);
            showMonAn.ShowDialog();*/
            Random rand = new Random();
            int index = rand.Next(danhSachMonAn.Count());
            ShowMonAn showMonAn = new ShowMonAn(danhSachMonAn.ElementAt(index));
            showMonAn.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*try
            {
                //if (await CheckAuthorization())
                //{
                comboBoxPageSize.Text = pagination.pageSize.ToString();
                GetDishes();
                //}
            }
            catch
            {
                Login login = new Login();
                login.ShowDialog();
            }*/
            comboBoxPageSize.Text = pagination.pageSize.ToString();
            GetDishes();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*TabPage? selectedTabPage = tabControl?.SelectedTab;
            if (selectedTabPage != null)
            {
                if (selectedTabPage.Name == "tabPage2")
                {
                    GetDishes(true);
                }
                if (selectedTabPage.Name == "tabPage1")
                {
                    GetDishes();
                }
            }*/
            if (tabControl.SelectedTab.Name == "tabPage2")
            {
                GetDishes(true);
            }
            else
            {
                GetDishes();
            }
        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int page = comboBoxPage.SelectedItem == null ? 1 : int.Parse(comboBoxPage.SelectedItem.ToString());
            int pageSize = comboBoxPageSize.SelectedItem != null ? int.Parse(comboBoxPageSize.SelectedItem.ToString()) : 5;
            pagination.pageSize = pageSize;
            pagination.current = page;
            tabControl_SelectedIndexChanged(sender, e);*/
            int page = int.Parse(comboBoxPage.SelectedItem.ToString());
            pagination.current = page;
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            /*ThemMonAn themMonAn = new ThemMonAn();
			themMonAn.FormClosed += tabControl1_SelectedIndexChanged;
			themMonAn.ShowDialog();*/
        }

        private void toolStripStatusLabelLogout_Click(object sender, EventArgs e)
        {
            /*var confirm = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (File.Exists("access_token"))
                {
                    File.Delete("access_token");
                    access_token = "Bearer ";
                    panelAllDishes.Controls.Clear();
                    panelMyDished.Controls.Clear();
                    //CheckAuthorization();
                }
            }*/
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete("access_token");
                this.Close();
            }
        }
    }
}
