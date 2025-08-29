namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbxPhepTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void lblNoitce_Click(object sender, EventArgs e)
        {

        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double number1, number2, result = 0;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                switch (CbxPhepTinh.SelectedItem.ToString())
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            lblNoitce.Visible = true;
                        lblNoitce.Text = "Không thể chia cho 0!";
                        break;
                    case "^":
                        result = Math.Pow(number1, number2);
                        break;
                    default:
                        lblNoitce.Visible = true;
                        lblNoitce.Text = "Vui lòng lựa chọn phép tính.";
                        return;
                }
                lblKetQua.Text = result.ToString();
                lblKetQua.Visible = true;
            }
            else
            {
                lblNoitce.Visible = true;
                lblNoitce.Text = "Các số phải được nhập đúng định dạng là số và không được bỏ trống!";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            lblKetQua.Visible = false;
            lblKetQua.Text = string.Empty;
            lblNoitce.Text = string.Empty;
            CbxPhepTinh.SelectedIndex = -1;
        }

    }
}
