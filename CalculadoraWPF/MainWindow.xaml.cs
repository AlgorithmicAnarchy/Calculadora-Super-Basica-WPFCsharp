using System;
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
            try
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
                        {
                            ResultadoTextBlock.Text = "Error: División por cero";
                            return;
                        }
                        break;
                }

                ResultadoTextBlock.Text = result.ToString();
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Error: Entrada no válida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(ResultadoTextBlock.Text);
                ResultadoTextBlock.Text = "";
                op = "sum";
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Error: Entrada no válida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Sub(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(ResultadoTextBlock.Text);
                ResultadoTextBlock.Text = "";
                op = "sub";
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Error: Entrada no válida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Multi(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(ResultadoTextBlock.Text);
                ResultadoTextBlock.Text = "";
                op = "multi";
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Error: Entrada no válida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Div(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(ResultadoTextBlock.Text);
                ResultadoTextBlock.Text = "";
                op = "div";
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Error: Entrada no válida";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e) { AppendNumber("1"); }
        private void Button_Click2(object sender, RoutedEventArgs e) { AppendNumber("2"); }
        private void Button_Click3(object sender, RoutedEventArgs e) { AppendNumber("3"); }
        private void Button_Click4(object sender, RoutedEventArgs e) { AppendNumber("4"); }
        private void Button_Click5(object sender, RoutedEventArgs e) { AppendNumber("5"); }
        private void Button_Click6(object sender, RoutedEventArgs e) { AppendNumber("6"); }
        private void Button_Click7(object sender, RoutedEventArgs e) { AppendNumber("7"); }
        private void Button_Click8(object sender, RoutedEventArgs e) { AppendNumber("8"); }
        private void Button_Click9(object sender, RoutedEventArgs e) { AppendNumber("9"); }
        private void Button_Click0(object sender, RoutedEventArgs e) { AppendNumber("0"); }

        private void AppendNumber(string number)
        {
            try
            {
                ResultadoTextBlock.Text += number;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el número: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Dec(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ResultadoTextBlock.Text.Contains("."))
                {
                    ResultadoTextBlock.Text += ".";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el decimal: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la ventana: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ButtonState == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mover la ventana: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
