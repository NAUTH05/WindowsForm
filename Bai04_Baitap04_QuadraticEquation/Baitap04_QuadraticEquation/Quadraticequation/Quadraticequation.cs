namespace Quadraticequation
{
    public partial class Quadraticequation : Form
    {
        public Quadraticequation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtA;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b) || !double.TryParse(txtC.Text, out c))
            {
                lblNoitce.Visible = true;
                lblNoitce.Text = "Vui lòng nhập đúng định dạng số cho a, b và c.";
                return;
            }

            lblNoitce.Visible = false;
            delta = b * b - 4 * a * c;
            
            if (delta < 0)
            {
                txtDelta.Text = "Delta = " + delta;
                txtDelta.Visible= true;
                lblPhuongTrinh.Visible = true;
                lblPhuongTrinh.Text = "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                txtDelta.Text = "Delta = " + delta;
                txtDelta.Visible = true;
                lblX1.Visible = true;
                lblPhuongTrinh.Visible = true;
                lblPhuongTrinh.Text = "Phương trình có nghiệm kép: ";
                lblX1.Text = "x1 = x2 = " + Math.Round(x1, 2);
            }
            else
            {
                txtDelta.Text = "Delta = " + delta;
                txtDelta.Visible = true;

                lblPhuongTrinh.Visible = true;
                lblX1.Visible = true;
                lblX2.Visible = true;

                x1 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                x2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                
                lblPhuongTrinh.Text = "Phương trình có hai nghiệm phân biệt: ";
                lblX1.Text = "x1 = " + x1;
                lblX2.Text = "x2 = " + x2;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtDelta.Text = string.Empty;
            lblKetQua.Text = string.Empty;
            lblPhuongTrinh.Visible = false;
            lblX1.Visible = false;
            lblX2.Visible = false;
            txtDelta.Visible = false;
            lblNoitce.Visible = false;
            txtA.Focus();
        }

        private void lblNoitce_Click(object sender, EventArgs e)
        {

        }

        private void txtDelta_Click(object sender, EventArgs e)
        {

        }
    }
}
