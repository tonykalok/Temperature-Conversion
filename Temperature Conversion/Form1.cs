namespace Temperature_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GetTempFromCelsiusToFahrenheit

        private void GetTempFromCelsiusToFahrenheit()
        {
            if (textBox1.Focused)
            {
                try
                {
                    double tempC = Convert.ToDouble(textBox1.Text);
                    textBox4.Text = ((tempC / 5 * 9) + 32).ToString("#.##");
                }
                catch (Exception)
                {
                    textBox4.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetTempFromCelsiusToFahrenheit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            GetTempFromCelsiusToFahrenheit();
        }

        #endregion

        #region GetTempFromFahrenheitToCelsius

        private void GetTempFromFahrenheitToCelsius()
        {
            if (textBox4.Focused)
            {
                try
                {
                    double tempF = Convert.ToDouble(textBox4.Text);
                    textBox1.Text = ((tempF - 32) * 5 / 9).ToString("#.##");
                }
                catch (Exception)
                {
                    textBox1.Text = "";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            GetTempFromFahrenheitToCelsius();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            GetTempFromFahrenheitToCelsius();
        }

        #endregion
    }
}