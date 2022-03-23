namespace Lr1Task3
{
    public partial class Form1 : Form
    {
        private int number;
        private int result;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(textBox1.Text);

                for (int i = 1; i <= number; i++)
                {
                    result += i;
                }

                textBox2.Text = result.ToString();
                result = 0;
            }
            catch
            {
                textBox2.Text = "¬ведите число!";
            }
        }
    }
}