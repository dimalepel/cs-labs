namespace Lr1Task7
{
    public partial class Calculator : Form
    {
        float a, b;
        int count;

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "0";
            } else if (textBoxResult.Text.Contains('0') && textBoxResult.Text.Length != 1)
            {
                textBoxResult.Text = textBoxResult.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "1";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "1";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length != 0 && !textBoxResult.Text.Contains(","))
            {
                textBoxResult.Text = textBoxResult.Text + ",";
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            calculate();
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            count = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "2";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "3";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "3";
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            count = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "4";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "5";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "6";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "6";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            count = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "7";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "8";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length == 0)
            {
                textBoxResult.Text = "9";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "9";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            count = 1;
        }

        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBoxResult.Text.Contains(",")))
            {
                e.Handled = true;
            } else if (textBoxResult.Text.Length == 1 && textBoxResult.Text.Contains('0') && (ch == 48 || ch == 96))
            {
                e.Handled = true;
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBoxResult.Text);
                    textBoxResult.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBoxResult.Text);
                    textBoxResult.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBoxResult.Text);
                    textBoxResult.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBoxResult.Text);
                    textBoxResult.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}