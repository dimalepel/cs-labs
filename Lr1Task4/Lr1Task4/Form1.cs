namespace Lr1Task4
{
    public partial class Form1 : Form
    {
        private double number;
        private double result;

        public Form1()
        {
            InitializeComponent();
        }

        private string convertDevideSymbol(string num)
        {
            return num.Replace('.', ',');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = double.Parse(convertDevideSymbol(textBox1.Text));

                result = Math.Abs(number);
                textBox2.Text = result.ToString();
            }
            catch
            {
                textBox2.Text = "Введите число!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                number = double.Parse(convertDevideSymbol(textBox1.Text));

                result = Math.Round(number);
                textBox2.Text = result.ToString();
            }
            catch
            {
                textBox2.Text = "Введите число!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                number = double.Parse(convertDevideSymbol(textBox1.Text));

                result = Math.Ceiling(number);
                textBox2.Text = result.ToString();
            }
            catch
            {
                textBox2.Text = "Введите число!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                number = double.Parse(textBox1.Text);

                result = Math.Floor(number);
                textBox2.Text = result.ToString();
            }
            catch
            {
                textBox2.Text = "Введите число!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                number = double.Parse(convertDevideSymbol(textBox1.Text));

                if (number < 0)
                {
                    textBox2.Text = "Нельзя вычислить результат!";
                } else
                {
                    result = Math.Sqrt(number);
                    textBox2.Text = result.ToString();
                }                
                
            }
            catch
            {
                textBox2.Text = "Введите число!";
            }
        }
    }
}