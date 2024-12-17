using System;

namespace WinFormscalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //???????????
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            //convert string to double
            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 + iNum2;
            result.Text = iResult.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //???????
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 / iNum2;
            result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //??????
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 - iNum2;
            result.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //???????
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;

            double iNum1 = Int32.Parse(inputNum1);
            double iNum2 = Int32.Parse(inputNum2);

            double iResult = iNum1 * iNum2;
            result.Text = iResult.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //clear textbox result
            result.Text = "";
            num1.Text = "";
            num2.Text = "";
        }
    }
}
