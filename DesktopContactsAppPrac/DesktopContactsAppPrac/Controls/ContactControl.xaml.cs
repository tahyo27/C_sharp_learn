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
using DesktopContactsAppPrac.Classes;

namespace DesktopContactsAppPrac.Controls
{
    /// <summary>
    /// ContactControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContactControl : UserControl
    {
        private Contact contact;

        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set 
            { 
                SetValue(ContactProperty, value);
            }
        }

        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(null, SetText) );

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ContactControl control && e.NewValue is Contact newContact)
            {
                control.nameTextBlock.Text = newContact.Name;
                control.emailTextBlock.Text = newContact.Email;
                control.phoneTextBlock.Text = newContact.Phone;
            }
        }

        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
