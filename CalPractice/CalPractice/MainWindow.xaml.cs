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

namespace CalPractice
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }
        public void Init()
        {
            resultLabel.Content = "0";
            acButton.Click += AcButton_Click;
            nagativeButton.Click += NagativeButton_Click;
            percentButton.Click += PercentButton_Click;
            equalButton.Click += EqualButton_Click;

            zeroButton.Click += NumberButton_Click;
            oneButton.Click += NumberButton_Click;
            twoButton.Click += NumberButton_Click;
            threeButton.Click += NumberButton_Click;
            fourButton.Click += NumberButton_Click;
            fiveButton.Click += NumberButton_Click;
            sixButton.Click += NumberButton_Click;
            sevenButton.Click += NumberButton_Click;
            eightButton.Click += NumberButton_Click;
            nineButton.Click += NumberButton_Click;

            pointButton.Click += PointButton_Click;
        }

        private void PointButton_Click(object sender, RoutedEventArgs e)
        {
            if(!resultLabel.Content.ToString().Contains("."))
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Sustraction:
                        result = SimpleMath.Sustraction(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }
                resultLabel.Content = result.ToString();
            }
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NagativeButton_Click(object sender, RoutedEventArgs e)
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

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
                {
                    resultLabel.Content = "0";
                }
                if(sender == multiplyButton)
                    selectedOperator = SelectedOperator.Multiplication;
                if (sender == divideButton)
                    selectedOperator = SelectedOperator.Division;
                if (sender == plusButton)
                    selectedOperator = SelectedOperator.Addition;
                if (sender == minusButton)
                    selectedOperator = SelectedOperator.Sustraction;
            }


        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                int.TryParse(btn.Content.ToString(), out int number);
                if (resultLabel.Content.ToString().Equals("0")) 
                {
                    resultLabel.Content = number;
                } 
                else 
                {
                    resultLabel.Content = $"{resultLabel.Content}{number}";
                }
            }
        }
    }
    public enum SelectedOperator
    {
        Addition,
        Sustraction,
        Multiplication,
        Division
    }

    public class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Sustraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }

}
