namespace Calculator
{
    public partial class Form1 : Form
    {

        string sign;
        double result = 0;
        double value1 = 0;
        double value2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign = "+";
            value1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sign = "-";
            value1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sign = "x";
            value1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = "÷";
            value1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sign == "+") { 
            
            value2 = Convert.ToInt64(textBox1.Text);
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
            if (sign == "-")
            {

                value2 = Convert.ToInt64(textBox1.Text);
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
            if (sign == "x")
            {

                value2 = Convert.ToInt64(textBox1.Text);
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            if (sign == "÷")
            {

                value2 = Convert.ToInt64(textBox1.Text);
                result = value1 / value2;
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}