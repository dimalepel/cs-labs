namespace Lr1Task5
{
    public partial class Form1 : Form
    {
        public float height;
        public float width;
        public float result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                height = float.Parse(heightValue.Text);

                if (height < 0)
                {
                    heightError.Text = "�������� ����� �����������!";
                } else
                {
                    heightError.Text = "";
                }
                
            } catch
            {
                heightError.Text = "�������� ����� �����������!";
            }

            try
            {
                width = float.Parse(widthValue.Text);
                
                if (width < 0)
                {
                    widthError.Text = "�������� ������ �����������!";
                }
                else
                {
                    widthError.Text = "";
                }
            }
            catch
            {
                widthError.Text = "�������� ������ �����������!";
            }

            if ((height > 0) && (width > 0))
            {
                result = width * height;
                resultValue.Text = result.ToString();
            }
            
        }
    }
}