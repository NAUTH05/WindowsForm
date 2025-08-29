namespace CompareNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NoitceLb_Click(object sender, EventArgs e)
        {

        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool IsNum1Valid = double.TryParse(Num1.Text, out num1);
            bool IsNum2Valid = double.TryParse(Num2.Text, out num2);

            if (!IsNum1Valid || !IsNum2Valid)
            {
                NoitceLb.Visible = true;
                NoitceLb.Text = "Vui lòng nhập cả 2 giá trị hợp lệ";
                return;
            }

            if (num1 < num2)
            {
                NoitceLb.Visible = true;
                NoitceLb.Text = "Vậy giá trị nhỏ nhất là: " + num1;
            }
            else if (num2 < num1)
            {
                NoitceLb.Visible = true;
                NoitceLb.Text = "Vậy giá trị nhỏ nhất là: " + num2;
            }
            else
            {
                NoitceLb.Visible = true;
                NoitceLb.Text = "Cả 2 số bằng nhau!";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NoitceLb.Visible=false;
            NoitceLb.Text = string.Empty;
            Num1.Clear();
            Num2.Clear();
        }
    }
}