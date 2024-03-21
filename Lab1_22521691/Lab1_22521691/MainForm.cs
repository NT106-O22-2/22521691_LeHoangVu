namespace Lab1_22521691
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void switch_to_task1(object sender, EventArgs e)
        {
            this.Hide();
            Task1 t1 = new Task1();
            t1.ShowDialog();
            this.Close();
        }

        private void switch_to_task2(object sender, EventArgs e)
        {
            this.Hide();
            Task2 t2 = new Task2();
            t2.ShowDialog();
            this.Close();
        }

        private void switch_to_task3(object sender, EventArgs e)
        {
            this.Hide();
            Task3 t3 = new Task3();
            t3.ShowDialog();
            this.Close();
        }

        private void switch_to_task4(object sender, EventArgs e)
        {
            this.Hide();
            Task4 t4 = new Task4();
            t4.ShowDialog();
            this.Close();
        }

        private void switch_to_task5(object sender, EventArgs e)
        {
            this.Hide();
            buyBtn t5 = new buyBtn();
            t5.ShowDialog();
            this.Close();
        }

        private void switch_to_task6(object sender, EventArgs e)
        {
            this.Hide();
            Task6 t6 = new Task6();
            t6.ShowDialog();
            this.Close();
        }

        private void switch_to_task7(object sender, EventArgs e)
        {
            this.Hide();
            Task7 t7 = new Task7();
            t7.ShowDialog();
            this.Close();
        }

        private void switch_to_task8(object sender, EventArgs e)
        {
            this.Hide();
            Task7 t7 = new Task7();
            t7.ShowDialog();
            this.Close();
        }

        private void switch_to_task9(object sender, EventArgs e)
        {
            this.Hide();
            Task9 t9 = new Task9();
            t9.ShowDialog();
            this.Close();
        }
    }
}
