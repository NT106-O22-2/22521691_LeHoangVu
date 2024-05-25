using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private string tokenType;
        private string accessToken;
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            try
            {
                using HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData);

                var res = await response.Content.ReadAsStringAsync();
                JObject keyValuePairs = JObject.Parse(res);

                if (response.IsSuccessStatusCode)
                {
                    tokenType = keyValuePairs["token_type"]?.ToString();
                    accessToken = keyValuePairs["access_token"]?.ToString();

                    if (!string.IsNullOrEmpty(tokenType) && !string.IsNullOrEmpty(accessToken))
                    {
                        richTextBox1.AppendText($"{tokenType} {accessToken}\nĐăng nhập thành công\n");
                    }
                    else
                    {
                        richTextBox1.AppendText("Không thể lấy token_type hoặc access_token\n");
                    }
                }
                else
                {
                    var detail = keyValuePairs["detail"]?.ToString() ?? "Đăng nhập không thành công";
                    richTextBox1.AppendText($"{detail}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tokenType) || string.IsNullOrEmpty(accessToken))
            {
                richTextBox1.AppendText("Chưa đăng nhập hoặc không có token\n");
                return;
            }
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                using HttpResponseMessage response = await httpClient.GetAsync("api/v1/user/me");

                var res = await response.Content.ReadAsStringAsync();
                JObject keyValuePairs = JObject.Parse(res);

                if (response.IsSuccessStatusCode)
                {
                    richTextBox1.AppendText($"{keyValuePairs.ToString()}\n");
                }
                else
                {
                    var detail = keyValuePairs["detail"]?.ToString() ?? "Lỗi khi lấy thông tin người dùng";
                    richTextBox1.AppendText($"{detail}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
