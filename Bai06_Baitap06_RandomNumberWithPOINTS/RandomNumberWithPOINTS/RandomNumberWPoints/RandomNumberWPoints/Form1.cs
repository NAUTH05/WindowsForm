namespace RandomNumberWPoints
{
    public partial class Form1 : Form
    {
        private int count;
        private int soLanThang = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void CBbox_Level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_SetNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TimerNumber_Click(object sender, EventArgs e)
        {

        }

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            int sodachon = txtbox_SetNumber.TextLength;
            if (lbl_TimerNumber.Text == txtbox_SetNumber.Text && sodachon != 0)
            {
                soLanThang++;
                txtbox_SoLanThang.Text = "Số Lần Thắng: " + soLanThang.ToString();
            }
            else
            {
                soLanThang--;
                txtbox_SoLanThang.Text = "Số Lần Thắng: " + soLanThang.ToString();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int soDatTruoc;
            if (CBbox_Level.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn cấp độ!");
                return;
            } 
            if (!int.TryParse(txtbox_SetNumber.Text, out soDatTruoc))
            {
                MessageBox.Show("Vui lòng nhập số!");
                return;
            }
            if (soDatTruoc < 0 || soDatTruoc > 9)
            {
                MessageBox.Show("Vui lòng chọn số từ 1 đến 9!");
                return;
            }

            if (CBbox_Level.SelectedItem.ToString() == "Easy")
            {
                Timer_Number.Interval = 1000;
                Timer_Number.Enabled = true;
            }
            else if (CBbox_Level.SelectedItem.ToString() == "Normal")
            {
                Timer_Number.Interval = 500;
                Timer_Number.Enabled = true;
            }
            else if (CBbox_Level.SelectedItem.ToString() == "Hard")
            {
                Timer_Number.Interval = 300;
                Timer_Number.Enabled = true;
            }
            else if (CBbox_Level.SelectedItem.ToString() == "BloodyHell")
            {
                Timer_Number.Interval = 100;
                Timer_Number.Enabled = true;
            }
        }

        private void txtbox_SoLanThang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Number_Tick(object sender, EventArgs e)
        {
            count = (short)((count + 1) % 10);
            lbl_TimerNumber.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Number.Enabled = false;
        }
    }
}
