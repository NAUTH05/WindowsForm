using System;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class Form2 : Form
    {
        private int soLuong;
        private int timerSet;
        private Random random;
        private int countdown;

        public Form2(int soLuong, int timerSet)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.soLuong = soLuong;
            this.timerSet = timerSet;
            this.random = new Random();
            this.countdown = timerSet;
            lblTimerSet.Text = countdown.ToString();
        }

        private void btnStartSpin_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            countdown = timerSet;
            lblTimerSet.Text = countdown.ToString() + "s";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSo1.Text = random.Next(0, 10).ToString();
            lblSo2.Text = random.Next(0, 10).ToString();
            lblSo3.Text = random.Next(0, 10).ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblTimerSet.Text = countdown.ToString() + "s";
            if (countdown <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                lblTimerSet.Text = "Hết giờ";
            }
        }

        private void lblSo1_Click(object sender, EventArgs e) { }
        private void lblSo2_Click(object sender, EventArgs e) { }
        private void lblSo3_Click(object sender, EventArgs e) { }
        private void lblTimerSet_Click(object sender, EventArgs e) { }

    }
}
