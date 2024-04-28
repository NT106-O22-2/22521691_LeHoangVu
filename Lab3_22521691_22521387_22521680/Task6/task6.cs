using Client1;
using sever1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }

        private void severBt_Click(object sender, EventArgs e)
        {
            sever sever = new sever();
            sever.Show();
        }

        private void ClientBt_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
        }
    }
}
