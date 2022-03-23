using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalc
{
    /// <summary>
    /// Интерактивная логика MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary <string, string> OperationDict; // Словарь, в котором хранятся два операнда и оператора
        string num2Str = ""; // Временная переменная для хранения второго числа

        public MainWindow()
        {
            InitializeComponent();
            Title = "Калькулятор";
            btnC.Click += BtnC_Click;
            btnE.Click += BtnE_Click;
            btnD.Click += new RoutedEventHandler(BtnOperator_Click);
            btnX.Click += new RoutedEventHandler(BtnOperator_Click);
            btnM.Click += new RoutedEventHandler(BtnOperator_Click);
            btnP.Click += new RoutedEventHandler(BtnOperator_Click);
            btn9.Click += new RoutedEventHandler(BtnNum_Click);
            btn8.Click += new RoutedEventHandler(BtnNum_Click);
            btn7.Click += new RoutedEventHandler(BtnNum_Click);
            btn6.Click += new RoutedEventHandler(BtnNum_Click);
            btn5.Click += new RoutedEventHandler(BtnNum_Click);
            btn4.Click += new RoutedEventHandler(BtnNum_Click);
            btn3.Click += new RoutedEventHandler(BtnNum_Click);
            btn2.Click += new RoutedEventHandler(BtnNum_Click);
            btn1.Click += new RoutedEventHandler(BtnNum_Click);
            btn0.Click += new RoutedEventHandler(BtnNum_Click);
            OperationDict = new Dictionary<string, string>();
        }

        private void BtnOperator_Click(object sender, RoutedEventArgs e) // Событие щелчка оператора
        {
            try
            {
                var opr = sender as Button;
                if (ShowNumText.Text == "")
                    return;

                switch (opr.Content.ToString())
                {
                    case "+":
                        OperationDict.Add("Operator", "+");
                        break;
                    case "—":
                        OperationDict.Add("Operator", "-");
                        break;
                    case "X":
                        OperationDict.Add("Operator", "*");
                        break;
                    case "/":
                        OperationDict.Add("Operator", "/");
                        break;
                }
                ShowNumText.Text += opr.Content.ToString();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
        }

        private void BtnE_Click(object sender, RoutedEventArgs e) // равно событию нажатия клавиши
        {
            try
            {
                ShowNumText.Text += "=";
                string str1 = "", str2 = "", opr = "";
                if (OperationDict.TryGetValue("Num1", out str1) && OperationDict.TryGetValue("Operator", out opr) && OperationDict.TryGetValue("Num2", out str2))
                {// Если два операнда и оператора в словаре не пусты, то выполнить операцию
                    int num1 = int.Parse(str1);
                    int num2 = int.Parse(str2);
                    switch (opr)
                    {
                        case "+":
                            ShowNumText.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            ShowNumText.Text = (num1 - num2).ToString();
                            break;
                        case "*":
                            ShowNumText.Text = (num1 * num2).ToString();
                            break;
                        case "/":
                            ShowNumText.Text = (num1 / num2).ToString();
                            break;
                    }
                    //MessageBox.Show(OperationDict["Num1"] + ":" + OperationDict["Operator"] + ":" + OperationDict["Num2"]);
                    OperationDict.Clear();
                    num2Str = "";
                    OperationDict.Add("Num1", ShowNumText.Text);
                }
                else
                {
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void BtnC_Click(object sender, RoutedEventArgs e) // Очистить событие нажатия клавиши
        {
            OperationDict.Clear();
            ShowNumText.Text = "";
            num2Str = "";
        }

        private void BtnNum_Click(object sender, RoutedEventArgs e) // Событие цифрового щелчка
        {
            var num = sender as Button;
            string value = "";
            if (!OperationDict.TryGetValue("Operator", out value))
            {// Оператор пуст, сохраненный номер является первым
                if (ShowNumText.Text == "")
                {
                    ShowNumText.Text = num.Content.ToString();
                    OperationDict.Add("Num1", num.Content.ToString());
                }
                else
                {
                    ShowNumText.Text += num.Content.ToString();
                    OperationDict["Num1"] = ShowNumText.Text;
                }
            }
            else
            {// Оператор не пуст, сохраненный номер является вторым
                if (num2Str == "")
                {
                    ShowNumText.Text += num.Content.ToString();
                    num2Str += num.Content.ToString();
                    OperationDict.Add("Num2", num.Content.ToString());
                }
                else
                {
                    ShowNumText.Text += num.Content.ToString();
                    num2Str += num.Content.ToString();
                    OperationDict["Num2"] = num2Str;
                }
            }

        }
    }
}