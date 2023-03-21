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

namespace CalculatorWPF
{
    public partial class MainWindow : Window
    {
        List<Button> numberButtons { get; set; } = new List<Button>();
        double numberOne { get; set; }
        bool numberOneExists { get; set; } = false;
        char sign { get; set; }
        double result { get; set; }
        bool equalPressed { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            numberButtons.Add(ButtonNumber0);
            numberButtons.Add(ButtonNumber1);
            numberButtons.Add(ButtonNumber2);
            numberButtons.Add(ButtonNumber3);
            numberButtons.Add(ButtonNumber4);
            numberButtons.Add(ButtonNumber5);
            numberButtons.Add(ButtonNumber6);
            numberButtons.Add(ButtonNumber7);
            numberButtons.Add(ButtonNumber8);
            numberButtons.Add(ButtonNumber9);
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            foreach (var i in numberButtons)
            {
                if (i == button) TextBox.Text += button.Content;
            }

            if (button == ButtonPlus)
            {
                if(numberOneExists)
                {
                    if(sign=='+') result = numberOne + Convert.ToDouble(TextBox.Text);
                    else if(sign=='-') result = numberOne - Convert.ToDouble(TextBox.Text);
                    else if(sign=='x') result = numberOne * Convert.ToDouble(TextBox.Text);
                    else if(sign=='/') result = numberOne / Convert.ToDouble(TextBox.Text);
                    numberOne = result;
                    TextBlock.Text = String.Format("{0:N4}", result) + " + ";
                    sign = '+';
                    TextBox.Text = string.Empty;
                    
                }
                else
                {
                    if (equalPressed)
                    {
                        TextBlock.Text = String.Format("{0:N4}", numberOne) + " + ";
                        sign = '+';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                        equalPressed = false;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(TextBox.Text);
                        TextBlock.Text += TextBox.Text + " + ";
                        sign = '+';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                    }
                }
                
            }

            if (button == ButtonMinus)
            {
                if (numberOneExists)
                {
                    if (sign == '+') result = numberOne + Convert.ToDouble(TextBox.Text);
                    else if (sign == '-') result = numberOne - Convert.ToDouble(TextBox.Text);
                    else if (sign == 'x') result = numberOne * Convert.ToDouble(TextBox.Text);
                    else if (sign == '/') result = numberOne / Convert.ToDouble(TextBox.Text);
                    numberOne = result;
                    TextBlock.Text = String.Format("{0:N4}", result) + " - ";
                    sign = '-';
                    TextBox.Text = string.Empty;

                }
                else
                {
                    if (equalPressed)
                    {
                        TextBlock.Text = String.Format("{0:N4}", numberOne) + " - ";
                        sign = '-';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                        equalPressed = false;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(TextBox.Text);
                        TextBlock.Text += TextBox.Text + " - ";
                        sign = '-';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                    }
                }
            }

            if (button == ButtonMulti)
            {
                if (numberOneExists)
                {
                    if (sign == '+') result = numberOne + Convert.ToDouble(TextBox.Text);
                    else if (sign == '-') result = numberOne - Convert.ToDouble(TextBox.Text);
                    else if (sign == 'x') result = numberOne * Convert.ToDouble(TextBox.Text);
                    else if (sign == '/') result = numberOne / Convert.ToDouble(TextBox.Text);
                    numberOne = result;
                    TextBlock.Text = String.Format("{0:N4}", result) + " x ";
                    sign = 'x';
                    TextBox.Text = string.Empty;

                }
                else
                {
                    if (equalPressed)
                    {
                        TextBlock.Text = String.Format("{0:N4}", numberOne) + " x ";
                        sign = 'x';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                        equalPressed = false;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(TextBox.Text);
                        TextBlock.Text += TextBox.Text + " x ";
                        sign = 'x';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                    }
                }
            }

            if (button == ButtonDiv)
            {
                if (numberOneExists)
                {
                    if (sign == '+') result = numberOne + Convert.ToDouble(TextBox.Text);
                    else if (sign == '-') result = numberOne - Convert.ToDouble(TextBox.Text);
                    else if (sign == 'x') result = numberOne * Convert.ToDouble(TextBox.Text);
                    else if (sign == '/') result = numberOne / Convert.ToDouble(TextBox.Text);
                    numberOne = result;
                    TextBlock.Text = String.Format("{0:N4}", result) + " / ";
                    sign = '/';
                    TextBox.Text = string.Empty;

                }
                else
                {
                    if (equalPressed)
                    {
                        TextBlock.Text = String.Format("{0:N4}", numberOne) + " / ";
                        sign = '/';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                        equalPressed = false;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(TextBox.Text);
                        TextBlock.Text += TextBox.Text + " / ";
                        sign = '/';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                    }
                }
            }

            if(button==ButtonSqrt)
            {
                if (numberOneExists)
                {
                    if (sign == '+') result = numberOne + Convert.ToDouble(TextBox.Text);
                    else if (sign == '-') result = numberOne - Convert.ToDouble(TextBox.Text);
                    else if (sign == 'x') result = numberOne * Convert.ToDouble(TextBox.Text);
                    else if (sign == '/') result = numberOne / Convert.ToDouble(TextBox.Text);
                    numberOne = result;
                    TextBlock.Text = String.Format("{0:N4}", result) + " / ";
                    sign = '/';
                    TextBox.Text = string.Empty;

                }
                else
                {
                    if (equalPressed)
                    {
                        TextBlock.Text = String.Format("{0:N4}", numberOne) + " / ";
                        sign = '/';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                        equalPressed = false;
                    }
                    else
                    {
                        numberOne = Convert.ToDouble(TextBox.Text);
                        TextBlock.Text += TextBox.Text + " / ";
                        sign = '/';
                        TextBox.Text = string.Empty;
                        numberOneExists = true;
                    }
                }
            }

            if (button == ButtonEqual)
            {
                if (sign == '+') result = numberOne + Convert.ToDouble(TextBox.Text);
                else if (sign == '-') result = numberOne - Convert.ToDouble(TextBox.Text);
                else if (sign == 'x') result = numberOne * Convert.ToDouble(TextBox.Text);
                else if (sign == '/') result = numberOne / Convert.ToDouble(TextBox.Text);
                numberOne = result;
                TextBlock.Text += TextBox.Text + " = " + String.Format("{0:N4}", result);
                numberOne = result;
                numberOneExists = false;
                equalPressed = true;
                TextBox.Text = string.Empty;
            }

        }


    }
}
