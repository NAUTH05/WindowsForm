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
            int sodachon = int.Parse(txtbox_SetNumber.Text);

            if (lbl_TimerNumber.Text == txtbox_SetNumber.Text)
            {
                switch (CBbox_Level.SelectedIndex)
                {
                    case 0:
                        soLanThang += 1;
                        break;
                    case 1:
                        soLanThang += 2;
                        break;
                    case 2:
                        soLanThang += 3;
                        break;
                    case 3:
                        soLanThang += 5;
                        break;
                }
            } else
            {
                soLanThang -= 1;
            }
            txtbox_SoLanThang.Text = "Số Lần Thắng: " + soLanThang.ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "Dừng")
            {
                btn_Start.Text = "Bắt Đầu";
                Timer_Number.Stop();       
                btn_Choose.Enabled = false;
                txtbox_SetNumber.ReadOnly = false; 
                return;
            }

            if (CBbox_Level.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn cấp độ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soDatTruoc;
            if (!int.TryParse(txtbox_SetNumber.Text, out soDatTruoc) || soDatTruoc < 0 || soDatTruoc > 9)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ trong phạm vi từ 0 đến 9!", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (CBbox_Level.SelectedIndex)
            {
                case 0:
                    Timer_Number.Interval = 1000;
                    break;
                case 1: 
                    Timer_Number.Interval = 500;
                    break;
                case 2:
                    Timer_Number.Interval = 250;
                    break;
                case 3:
                    Timer_Number.Interval = 100;
                    break;
                default:
                    break;
            }

            Timer_Number.Start();

            btn_Start.Text = "Dừng";
            btn_Choose.Enabled = true;
            txtbox_SetNumber.ReadOnly = true;
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
            btn_Choose.Enabled = false;
            txtbox_SetNumber.ReadOnly = false;
        }
    }
}
