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
        public MainWindow()
        {
            InitializeComponent();

            resultLabel.Content = "14321";
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
