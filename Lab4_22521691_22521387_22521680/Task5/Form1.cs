using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json;

namespace Task5
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

            using HttpResponseMessage response = await httpClient.PostAsync(
                "auth/token",
                formData
            );

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);

            MessageBox.Show(keyValuePairs["access_token"].ToString());
        }
    }
}
