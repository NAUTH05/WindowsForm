using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class Form4 : Form
    {
        private int soLuong;
        private int timerSet;
        private Random random;
        private int countdown;
        public Form4(int soLuong, int timerSet)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.random = new Random();
            this.countdown = timerSet;
            lblTimerSet.Text = countdown.ToString() + "s";
            this.soLuong = soLuong;
            this.timerSet = timerSet;
        }

        private void lblSo1_Click(object sender, EventArgs e)
        {

        }

        private void lblSo1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSo2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartSpin_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            countdown = timerSet;
            lblTimerSet.Text = countdown.ToString() + "s";
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSo1.Text = random.Next(0, 10).ToString();
            lblSo2.Text = random.Next(0, 10).ToString();
            lblSo3.Text = random.Next(0, 10).ToString();
            lblSo4.Text = random.Next(0, 10).ToString();
        }
    }
}
