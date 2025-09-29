namespace QuaySo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txtSoLuong;

            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimerSet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtSoLuong.Text);
            int timerSet = int.Parse(txtTimerSet.Text);

            if (soluong == 3)
            {
                Form2 f2 = new Form2(soluong, timerSet);
                f2.Show();
            }

            if (soluong == 2)
            {
                Form3 f3 = new Form3(soluong, timerSet);
                f3.Show();
            }

            if (soluong == 4)
            {
                Form4 f4 = new Form4(soluong, timerSet);
                f4.Show();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
