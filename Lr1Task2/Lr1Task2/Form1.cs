namespace Lr1Task2
{
    public partial class Form1 : Form
    {
        private int digit = 5;
        private int currentNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���������� ��� ����� ��������� � �� ���������� ������ ��� �� ������
            //this.currentNumber = int.Parse(textBox1.Text);

            try
            {
                this.currentNumber = int.Parse(textBox1.Text);

                if (digit == currentNumber)
                {
                    textBox2.Text = "������";
                }
                else
                {
                    textBox2.Text = "�� ������";
                }
            }
            catch
            {
                textBox2.Text = "������� �����!";
            }
            
        }
    }
}