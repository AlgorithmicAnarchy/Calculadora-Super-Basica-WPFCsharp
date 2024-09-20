using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CalculadoraWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        double result;
        string op;

        private void Button_Igual(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToDouble(ResultadoTextBlock.Text);

            switch (op)
            {
                case "sum":
                    result = num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "multi":
                    result = num1 * num2;
                    break;
                case "div":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        ResultadoTextBlock.Text = "Error";
                    return;
            }

            ResultadoTextBlock.Text = result.ToString();
        }

        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(ResultadoTextBlock.Text);
            ResultadoTextBlock.Text = "";
            op = "sum";
        }

        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(ResultadoTextBlock.Text);
            ResultadoTextBlock.Text = "";
            op = "sub";
        }

        private void Button_Multi(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(ResultadoTextBlock.Text);
            ResultadoTextBlock.Text = "";
            op = "multi";
        }

        private void Button_Div(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(ResultadoTextBlock.Text);
            ResultadoTextBlock.Text = "";
            op = "div";
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "1";
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "2";
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "3";
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "4";
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "5";
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "6";
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "7";
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "8";
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "9";
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text += "0";
        }

        private void Button_Dec(object sender, RoutedEventArgs e)
        {
            if (!ResultadoTextBlock.Text.Contains("."))
            {
                ResultadoTextBlock.Text += ".";
            }
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
