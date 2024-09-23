using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace ROUXDECORZENTLeopoldScientificCalculator
{
/// <summary>
/// Logique d'interaction pour MainWindow.xaml
/// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          

        }

 // Déclaration des variable/ Declaration of variables
        double num1 =0;
        double num2 =0;
        double result = 0;
        char Operation;


        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            Operation = '+';
        }

        private void BTN_Minus_Click(object sender, RoutedEventArgs e)
        {

            num1 = float.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            Operation = '-';
        }

        private void BTN_Multiplication_Click(object sender, RoutedEventArgs e)
        {

            num1 = float.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            Operation = '*';
        }

        private void BTN_Divide_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            Operation = '/';

        }

        private void BTN_Equal_Click(object sender, RoutedEventArgs e)
        {

            num2 = double.Parse(TB_Display.Text);

            switch (Operation)
            {
                case '+':
                    result = num1 + num2;
                    TB_Display.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    TB_Display.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    TB_Display.Text = result.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        TB_Display.Text = result.ToString();
                    }
                    else
                    {
                        TB_Display.Text = "Error";
                    }
                    break;

            }

        }

        private void BTN_Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!TB_Display.Text.Contains(","))
            { TB_Display.Text = TB_Display.Text + ","; }
            else             {
                TB_Display.Text = TB_Display.Text;
            }
            

        }

        private void BTN_Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Length > 0)
            {
                TB_Display.Text = TB_Display.Text.Remove(TB_Display.Text.Length - 1, 1);
            }
            if (TB_Display.Text == "")
            {
                TB_Display.Text = "0";
            }
        }

        private void BTN_Negative_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("-"))
            {
                TB_Display.Text = TB_Display.Text.Remove(0, 1);
            }
            else
            {
                TB_Display.Text = "-" + TB_Display.Text;
            }
        }

        private void BTN_Percentage_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(TB_Display.Text);
            result = num1 / 100;
            TB_Display.Text = result.ToString();
        }

        private void BTN_SquareRoot_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(TB_Display.Text);
            result = Math.Sqrt(num1);
            TB_Display.Text = result.ToString();
        }

        //lugjkuggg

        private void BTN_Reciprocal_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(TB_Display.Text);
            result = 1 / num1;
            TB_Display.Text = result.ToString();
        }

        private void BTN_ClearAll_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
        }

        private void BTN_Square_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(TB_Display.Text);
            result = num1 * num1;
            TB_Display.Text = result.ToString();
        }
        
        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";

        }

// Définition des différents boutons de la calculatrice/ Defining the different buttons of the calculator

     private void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }

        }

// Fonction pour afficher les chiffres sur l'écran de la calculatrice/ Function to display the numbers on the calculator screen
        
    }
}

