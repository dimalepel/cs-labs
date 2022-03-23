namespace Lr1Task6
{
    public partial class Form1 : Form
    {
        string[] endings = { "ñèìâîë", "ñèìâîëà", "ñèìâîëîâ" };

        public Form1()
        {
            InitializeComponent();
        }

        private string getNumEnding(float number, string[] endings)
        {
            number = number % 100;
            string ending = " ";

            if (number >= 11 && number <= 19)
            {
                ending = endings[2];
            } else
            {
                float index = number % 10;
                switch (index)
                {
                    case (1): 
                        ending = endings[0];
                        break;
                    case (2):
                    case (3):
                    case (4):
                        ending = endings[1];
                        break;
                    default:
                        ending = endings[2];
                        break;
                }
            }

            return ending;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_text = textField.Text;
            int result = input_text.Length;

            textContent.Text = "Âû ââåëè " + result + " " + getNumEnding(result, endings);
        }
    }
}