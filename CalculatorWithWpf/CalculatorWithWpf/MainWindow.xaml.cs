using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWithWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            if (sender == zeroButton)
            {
                selectedValue = 0;
            }
            else if (sender == oneButton)
            {
                selectedValue = 1;
            }
            else if (sender == twoButton)
            {
                selectedValue = 2;
            }
            else if (sender == threeButton)
            {
                selectedValue = 3;
            }
            else if (sender == fourButton)
            {
                selectedValue = 4;
            }
            else if (sender == fiveButton)
            {
                selectedValue = 5;
            }
            else if (sender == sixButton)
            {
                selectedValue = 6;
            }
            else if (sender == sevenButton)
            {
                selectedValue = 7;
            }
            else if (sender == eightButton)
            {
                selectedValue = 8;
            }
            else if (sender == nineButton)
            {
                selectedValue = 9;
            }
            if (resultLabel.Content.ToString().Equals("0"))
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }
}