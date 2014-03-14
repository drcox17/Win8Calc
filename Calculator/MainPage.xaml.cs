using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Calculator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ValuText.IsReadOnly = true;
        }
        string opration;
        double num1, num2, result;
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "1";
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "2";
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "3";
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "4";
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "5";
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "6";
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "7";
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "8";
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "9";
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }
        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Contains("."))
            {
                TextBox.Text = TextBox.Text;
            }
            else
            {
                TextBox.Text = TextBox.Text + ".";
            }
        }
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "+";
                TextBox.Text = "";
                ValuText.Text = num1 + "+";
            }
        }
        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "-";
                TextBox.Text = "";
                ValuText.Text = num1 + "-";
            }
        }
        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "*";
                TextBox.Text = "";
                ValuText.Text = num1 + "*";
            }
        }
        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "/";
                TextBox.Text = "";
                ValuText.Text = num1 + "/";
            }
        }
        private void BtnPer_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "%";
                TextBox.Text = "";
                ValuText.Text = num1 + "%";
            }
        }
        private void BtnSqr_Click(object sender, RoutedEventArgs e)
        {
            if(TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Sqrt(num1));
            }
        }
        private void BtnCan_Click(object sender, RoutedEventArgs e)
        {
            int length = TextBox.Text.Length;
            if (length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(length - 1);
            }
            else
            {
                TextBox.Text = TextBox.Text;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            ValuText.Text = "";
        }
        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num2 = double.Parse(TextBox.Text);
                ValuText.Text = "";
                switch (opration)
                {
                    case "+":
                        result = num1 + num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "-":
                        result = num1 - num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "*":
                        result = num1 * num2;
                        TextBox.Text = result.ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            ValuText.Text = "Cannot divide by zero";
                            break;
                        }
                        else
                        {
                            result = num1 / num2;
                            TextBox.Text = result.ToString();
                            break;
                        }
                    case "%":
                        num1 = num1 * num2;
                        result = num1 / 100;
                        TextBox.Text = result.ToString();
                        break;
                    case "^":
                        result = Math.Pow(num1, num2);
                        TextBox.Text = result.ToString();
                        break;
                    default:
                        TextBox.Text = "Error";
                        break;
                }
            }
        }

        private void BtnASin_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Asin(num1));
            }
        }

        private void BtnACos_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Acos(num1));
            }
        }

        private void BtnATan_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Atan(num1));
            }
        }

        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Sin(num1));
            }
        }

        private void BtnCos_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Cos(num1));
            }
        }

        private void BtnTan_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Tan(num1));
            }
        }

        private void BtnSinH_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Sinh(num1));
            }
        }

        private void BtnCosH_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Cosh(num1));
            }
        }

        private void BtnTanH_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                TextBox.Text = "";
                ValuText.Text = Convert.ToString(Math.Tanh(num1));
            }
        }

        private void BtnExp_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                opration = "^";
                TextBox.Text = "";
                ValuText.Text = num1 + "^";
            }
        }
    }
}