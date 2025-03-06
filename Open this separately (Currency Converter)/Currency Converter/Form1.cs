namespace Currency_Converter
{
    public partial class Form1 : Form
    {

        double value1;
        double value2;
        string currency1;
        string currency2;
        double result;

        public Form1()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currency1 == "USD" && currency2 == "USD" || currency1 == "PKR" && currency2 == "PKR" || currency1 == "BITCOIN" && currency2 == "BITCOIN")
            {

                textBox1.Text = Convert.ToString("Cannot convert the same currency");

            }
            else if(currency1 == "USD" && currency2 == "PKR") {

                result = 280 * Convert.ToInt64(textBox1.Text);
                textBox1.Text = Convert.ToString(result);

            
            }
            else if (currency1 == "USD" && currency2 == "BITCOIN")
            {

                result = 0.000011 * Convert.ToInt64(textBox1.Text);
                textBox1.Text = Convert.ToString(result);


            }
            else if (currency1 == "PKR" && currency2 == "USD")
            {

                result = Convert.ToInt64(textBox1.Text) / 280;
                textBox1.Text = Convert.ToString(result);


            }

            else if (currency1 == "PKR" && currency2 == "BITCOIN")
            {

                result = Convert.ToInt64(textBox1.Text) * 0.000000038;
                textBox1.Text = Convert.ToString(result);


            }

            else if (currency1 == "BITCOIN" && currency2 == "USD")
            {

                result = Convert.ToInt64(textBox1.Text) * 89656;
                textBox1.Text = Convert.ToString(result);


            }
            else if (currency1 == "BITCOIN" && currency2 == "PKR")
            {

                result = Convert.ToInt64(textBox1.Text) * 26581496;
                textBox1.Text = Convert.ToString(result);


            }

            else {

                textBox1.Text = Convert.ToString("Plese re-enter the currencies");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            currency1 = comboBox1.SelectedItem.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency2 = comboBox2.SelectedItem.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}