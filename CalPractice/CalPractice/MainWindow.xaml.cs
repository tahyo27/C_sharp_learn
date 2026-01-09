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
        double lastNumber;
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
            equalButton.Click += EqualButton_Click;

            // Operation
            multiplyButton.Click += OperationButton_Click;
            minusButton.Click += OperationButton_Click;
            plusButton.Click += OperationButton_Click;
            divideButton.Click += OperationButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NagativeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                int.TryParse(resultLabel.Content.ToString(), out int result);

                switch(btn.Name)
                {
                    case "multiplyButton":
                        break;
                    case "plusButton":
                        break;
                    case "minusButton":
                        break;
                    case "divideButton":
                        break;
                }
            }


        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
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
}
