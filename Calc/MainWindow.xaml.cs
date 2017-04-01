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
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

           var myNumber = int.Parse(input.Text) + int.Parse(input2.Text);
            AnswerDisplay.Text = myNumber.ToString();

        }
        private void Subtrack_Click(object sender, RoutedEventArgs e)
        {
            var myNumber = int.Parse(input.Text) - int.Parse(input2.Text);
            AnswerDisplay.Text = myNumber.ToString();

        }

        private void Multi_Click_1(object sender, RoutedEventArgs e)
        {
            var myNumber = int.Parse(input.Text) * int.Parse(input2.Text);
            AnswerDisplay.Text = myNumber.ToString();
        }

        private void Divid_Click(object sender, RoutedEventArgs e)
        {
            var myNumber = int.Parse(input.Text) / int.Parse(input2.Text);
            AnswerDisplay.Text = myNumber.ToString();

        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            var myNumber = int.Parse(input.Text) % int.Parse(input2.Text);
            AnswerDisplay.Text = myNumber.ToString();
        }

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void input2_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void AnswerDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

    }
}
