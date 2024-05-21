using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task3
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        private void severBt_Click(object sender, EventArgs e)
        {
            sever sever = new sever();
            sever.Show();
        }

        private void clientBt_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
        }
    }
}
