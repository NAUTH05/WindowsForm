using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUCKY_SEVEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void THONGBAO_TextChanged(object sender, EventArgs e)
        {

        }
        private void Num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SPIN_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] numbers = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = r.Next(1, 8);
            }

            Num1.Text = numbers[0].ToString();
            Num2.Text = numbers[1].ToString();
            Num3.Text = numbers[2].ToString();

            if (numbers[0] == 7|| numbers[1] == 7|| numbers[2] == 7)
            {
                THONGBAO.Text = $"Congratulations! You won with {numbers[0]}, {numbers[1]}, {numbers[2]}!";
            }
            else
            {
                THONGBAO.Text = $"Try again! You got {numbers[0]}, {numbers[1]}, {numbers[2]}.";
            }
            
        }

        private void STOP_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
