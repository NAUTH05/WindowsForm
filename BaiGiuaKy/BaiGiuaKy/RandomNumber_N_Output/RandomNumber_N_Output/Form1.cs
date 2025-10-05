namespace RandomNumber_N_Output
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int min, max, times;
        List<int> resultlist = new List<int>();
        public Form1()
        {
            InitializeComponent();
            txbox_OutPut.ReadOnly = true;
            this.Shown += (s, e) => { txbox_MinNumber.Focus(); };
        }

        private void txbox_MinNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbox_MaxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(txbox_MinNumber.Text);
            max = Convert.ToInt32(txbox_MaxNumber.Text);
            times = Convert.ToInt32(txbox_Times.Text);
            List<int> outputList = Enumerable.Range(min, max - min + 1).ToList();
            for (int i = outputList.Count - 1; i > 0; i--)
            {
                int j = r.Next(0, i + 1);
                (outputList[i], outputList[j]) = (outputList[j], outputList[i]);
            }
            resultlist = outputList.Take(times).ToList();
            txbox_OutPut.Text = string.Join(", ", resultlist);
        }

        private void txbox_OutPut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbox_Times_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SortAZ_Click(object sender, EventArgs e)
        {
            resultlist.Sort();
            txbox_OutPut.Text = string.Join(", ", resultlist);
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            resultlist.Sort();
            resultlist.Reverse();
            txbox_OutPut.Text = string.Join(", ", resultlist);
        }
    }
}
