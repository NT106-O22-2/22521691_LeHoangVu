using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json;
namespace Bai05
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
                using HttpResponseMessage response = await httpClient.PostAsync(
                "auth/token",
                formData
                );

                var res = await response.Content.ReadAsStringAsync();
                JObject keyValuePairs = JObject.Parse(res);

                if (response.IsSuccessStatusCode)
                {
                    string tokenType = keyValuePairs["token_type"].ToString();
                    string accessToken = keyValuePairs["access_token"].ToString();
                    richTextBox1.AppendText($"{tokenType} {accessToken}\nĐăng nhập thành công\n");
                }
                else
                {
                    string detail = keyValuePairs["detail"]?.ToString() ?? "Đăng nhập không thành công";
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
