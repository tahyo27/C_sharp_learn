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

namespace InvoiceManagementApp
{
    /// <summary>
    /// LoginView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envPw != null)
            {
                if(passwordEntered == envPw)
                {
                    MessageBox.Show("Enter correct Password");
                }
                else
                {
                    MessageBox.Show("Enter wrong Password");
                }
                
            }
            else
            {
                MessageBox.Show("Enviroment variable not found");
            }
            
        }

        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginBtn.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
