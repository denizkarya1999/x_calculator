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

namespace x_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> Numbers = new List<double>();
        double result;
        bool first_round = true;
        string action = " ";
        string btn_clcked = "no";
        string repeated = "no";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_assigner(string number_in_text)
        {
            Numbers.Add(Double.Parse(number_in_text));
        }

        private void zero_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0"))
            {
                result_label.Text = "0";
            }    
            else
            {
                result_label.Text = result_label.Text + "0";
            }
        }

        private void one_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "1";
            }
            else
            {
                result_label.Text = result_label.Text + "1";
            }
        }

        private void two_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "2";
            }
            else
            {
                result_label.Text = result_label.Text + "2";
            }
        }
            private void three_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "3";
            }
            else
            {
                result_label.Text = result_label.Text + "3";
            }
        }
        private void four_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "4";
            }
            else
            {
                result_label.Text = result_label.Text + "4";
            }
        }

        private void five_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "5";
            }
            else
            {
                result_label.Text = result_label.Text + "5";
            }
        }
        private void six_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "6";
            }
            else
            {
                result_label.Text = result_label.Text + "6";
            }
        }

        private void seven_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "7";
            }
            else
            {
                result_label.Text = result_label.Text + "7";
            }
        }

        private void eight_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "8";
            }
            else
            {
                result_label.Text = result_label.Text + "8";
            }
        }

        private void nine_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals("Second number!"))
            {
                result_label.Text = "9";
            }
            else
            {
                result_label.Text = result_label.Text + "9";
            }
        }

        private void dot_button_Click(object sender, RoutedEventArgs e)
        {
            if (result_label.Text.Equals("0") || result_label.Text.Equals(result_label.Text) && repeated == "no")
            {
                result_label.Text = result_label.Text + ".";
                repeated = "yes";
            }
                
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            result_label_2.Text = "Add";
            result_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "add";
            repeated = "no";
        }

        private void equals_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            double result = 0.0;
            if (action.Equals("add"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max + min;
            }
            if (action.Equals("substract"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max - min;
            }
            if (action.Equals("divide"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max / min;
            }
            if (action.Equals("multiply"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max * min;
            }
            if (action.Equals("modulus"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max % min;
            }
            result_label.Text = result.ToString();
            result_label_2.Text = "";
            Numbers.Clear();
            btn_clcked = "no";
        }

        private void ce_button_Click(object sender, RoutedEventArgs e)
        {
            result_label.Text = "0";
            result_label_2.Text = "";
            repeated = "yes";
            repeated = "no";
        }

        private void subscription_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            result_label_2.Text = "Substract";
            result_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "substract";
            repeated = "no";
        }

        private void division_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            result_label_2.Text = "Divide";
            result_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "divide";
            repeated = "no";
        }

        private void multiply_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            result_label_2.Text = "Multiply";
            result_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "multiply";
            repeated = "no";
        }

        private void percent_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(result_label.Text);
            result_label_2.Text = "Modulus";
            result_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "modulus";
            repeated = "no";
        }

        private void square_root_button_Click(object sender, RoutedEventArgs e)
        {
            square_root_of_number(result_label.Text);
            repeated = "no";
        }

        private void square_root_of_number(string number)
        {
            double result = 0.0;
            result = Math.Sqrt(Double.Parse(number));
            result_label.Text = result.ToString();
            result_label_2.Text = "";
            Numbers.Clear();
            btn_clcked = "no";
        }

        private void about_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2021 © Deniz K. Acikbas. All rights are reserved.", "About");
        }
    }
}
