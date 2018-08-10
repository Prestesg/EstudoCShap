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

namespace AulaWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public int operacao { get; set; }
        public double resultado { get; set; }
        public string memoria { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            var display = (string) PrimeiroArg.Content;
            display += '1';
            PrimeiroArg.Content = display;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '2';
            PrimeiroArg.Content = display;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '3';
            PrimeiroArg.Content = display;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '4';
            PrimeiroArg.Content = display;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '5';
            PrimeiroArg.Content = display;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '6';
            PrimeiroArg.Content = display;
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '7';
            PrimeiroArg.Content = display;
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '8';
            PrimeiroArg.Content = display;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '9';
            PrimeiroArg.Content = display;
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            display += '0';
            PrimeiroArg.Content = display;
        }

        private void vezes_Click(object sender, RoutedEventArgs e)
        {
            operacao = 1;
            var display = (string)PrimeiroArg.Content;
            display += '*';
            PrimeiroArg.Content = display;
        }

        private void mais_Click(object sender, RoutedEventArgs e)
        {
            operacao = 2;
            var display = (string)PrimeiroArg.Content;
            display += '+';
            PrimeiroArg.Content = display;
        }

        private void menos_Click(object sender, RoutedEventArgs e)
        {
            operacao = 3;
            var display = (string)PrimeiroArg.Content;
            display += '-';
            PrimeiroArg.Content = display;
        }

        private void dividido_Click(object sender, RoutedEventArgs e)
        {
            operacao = 4;
            var display = (string)PrimeiroArg.Content;
            display += '/';
            PrimeiroArg.Content = display;
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            string display = (string)PrimeiroArg.Content;
            string[] argumentos = display.Split('-','+','*','/','|');

            double argumento1 = Convert.ToDouble(argumentos[0]);
            double argumento2 = Convert.ToDouble(argumentos[1]);
            switch (operacao)
            {
                case 1:
                    resultado = argumento1 * argumento2;
                    display = Convert.ToString(resultado);
                    break;
                case 2:
                    resultado = argumento1 + argumento2;
                    display = Convert.ToString(resultado);
                    break;
                case 3:
                    resultado = argumento1 - argumento2;
                    display = Convert.ToString(resultado);
                    break;
                case 4:
                    resultado = argumento1 / argumento2;
                    display = Convert.ToString(resultado);
                    break;
                case 5:
                    resultado = Math.Pow(argumento1,argumento2);
                    display = Convert.ToString(resultado);
                    break;
                default:
                    resultado = argumento1 * argumento2;
                    display = Convert.ToString(resultado);
                    break;
            }
            PrimeiroArg.Content = display;
        }

        private void limpar_Click(object sender, RoutedEventArgs e)
        {
            PrimeiroArg.Content = "";
        }

        private void elevar_Click(object sender, RoutedEventArgs e)
        {
            operacao = 5;
            var display = (string)PrimeiroArg.Content;
            display += '|';
            PrimeiroArg.Content = display;
        }

        private void raiz_Click(object sender, RoutedEventArgs e)
        {
                var display = (string)PrimeiroArg.Content;
                double argumento1 = Convert.ToDouble(display);
                resultado =  Math.Sqrt(argumento1);
                display = Convert.ToString(resultado);         
                PrimeiroArg.Content = display;
        }

        private void memoria_Click(object sender, RoutedEventArgs e)
        {
            var display = (string)PrimeiroArg.Content;
            
            if (String.IsNullOrEmpty(memoria))
            {
                memoria = display;
            } else
            {
                PrimeiroArg.Content += memoria;
            }
        }
    }
}
