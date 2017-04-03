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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            decimal MemoryOutputs = 0;
            decimal MemoryEndResult = 0;
        

        public MainWindow()
        {
            InitializeComponent();
        }

       
        //number pad on the calc
        private void TheNumButtons(object sender, RoutedEventArgs e)
        {
            input.Text += (string)((Button)sender).Content;
        }
        // textbox
        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // all number buttons
        private void CLick_Click(object sender, RoutedEventArgs e)
        {
            input.Text += " " + (string)((Button)sender).Content + " ";
        }
        // euqals button
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            string[] text = input.Text.Split(' ');

                double n1 = double.Parse(text[0]);
                double n2 = double.Parse(text[2]);

            if(text[1] == "+")
            {
                input.Text = (n1 + n2).ToString();
            }
            else if (text[1] == "-")
            {
                input.Text = (n1 - n2).ToString();
            }
            else if (text[1] == "/")
            {
                if (n2 == 0.0)
                    input.Text = "why are we friends";
                else
                    input.Text = (n1 / n2).ToString();
            }
            else if (text[1] == "*")
            {
                input.Text = (n1 * n2).ToString();
            }
        }
        // clear button
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            input.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text.Remove(input.Text.Length - 1, 1);
        }


        private void Memory_Click(object sender, RoutedEventArgs e)
        {

            Button MemoryButtonsPushed = (Button)sender;
            string MemButtonTxt = MemoryButtonsPushed.Text;

        }
    }
}
