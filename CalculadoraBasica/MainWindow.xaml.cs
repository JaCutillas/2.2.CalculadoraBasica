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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularOnClick(object sender, RoutedEventArgs e)
        {
            decimal operando1;
            decimal operando2;

            try 
            {
                operando1 = decimal.Parse(operando1TextBox.Text);
                operando2 = decimal.Parse(operando2TextBox.Text);

                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        resultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        resultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        resultadoTextBox.Text = (operando1 / operando2).ToString();
                        break;
                    default:
                        MessageBox.Show("Si esto sale algo va mal en el metodo calcular");
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("Introduce un numero por favor");
            }  
        }

        private void LimpiarOnClick(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = string.Empty;
            operando2TextBox.Text = string.Empty;
            operadorTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;

        }

        private void OperadorChanged(object sender, TextChangedEventArgs e)
        {
            switch (operadorTextBox.Text)
            {
                case "+":
                    calcularButton.IsEnabled = true;
                    break;
                case "-":
                    calcularButton.IsEnabled = true;
                    break;
                case "*":
                    calcularButton.IsEnabled = true;
                    break;
                case "/":
                    calcularButton.IsEnabled = true;
                    break;
                default:
                    calcularButton.IsEnabled = false;
                    break;
            }
        }
    }
}
