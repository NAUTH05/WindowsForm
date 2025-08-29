namespace ChangeCaption
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

        private void ChangeBTN_Click(object sender, EventArgs e)
        {
            string input = TxtBox.Text;
            if (!string.IsNullOrEmpty(input))
            {
                this.Text = input;
                WarningLB.Visible = true;
                WarningLB.Text = "Bạn đã thay đổi tên form thành " + input;
            } else
            {
                WarningLB.Visible = true;
                WarningLB.Text = "Vui lòng nhập tên để thay đổi";
            }
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WarningLB_Click(object sender, EventArgs e)
        {

        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();
            WarningLB.Visible = false;
            this.Text = "CHANGE-CAPTION";
        }
    }
}