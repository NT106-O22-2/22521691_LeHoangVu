using MailKit.Net.Imap;
using MailKit;
using MimeKit;


namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(username, password);

                    MessageBox.Show("Login successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lvEmails.Items.Clear();
                    int recentCount = 0;
                    int totalCount = inbox.Count;
                    lbTotal.Text = $"{totalCount}";

                    for (int i = 0; i < Math.Min(20, inbox.Count); i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(new[] {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.ToString()
                        });
                        lvEmails.Items.Add(item);
                        if (message.Date >= DateTime.UtcNow.AddDays(-7))
                        {
                            recentCount++;
                        }
                    }
                    lbRecent.Text = $" {recentCount}";

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
