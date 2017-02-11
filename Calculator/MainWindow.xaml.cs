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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text.Contains("="))
                Result.Text = "";
            Button b = (Button)sender;
            Result.Text += b.Content.ToString();

        }
        private void Equal_click(object sender, RoutedEventArgs e)
        {
            try
            {
                calculate();
            }
            catch (Exception ex)
            {
                Result.Text = "Error!";
            }
        }

        private void calculate()
        {
            String op;
            int iOp = 0;
            if (Result.Text.Contains("+"))
            {
                iOp = Result.Text.IndexOf("+");
            }
            else if (Result.Text.Contains("-"))
            {
                iOp = Result.Text.IndexOf("-");
            }
            else if (Result.Text.Contains("*"))
            {
                iOp = Result.Text.IndexOf("*");
            }
            else if (Result.Text.Contains("/"))
            {
                iOp = Result.Text.IndexOf("/");
            }
            else
            {
                //error
            }

            op = Result.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(Result.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(Result.Text.Substring(iOp + 1, Result.Text.Length - iOp - 1));

            if (op == "+")
            {
                Result.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                Result.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                Result.Text += "=" + (op1 * op2);
            }
            else
            {
                Result.Text += "=" + (op1 / op2);
            }
        }

    }
}
