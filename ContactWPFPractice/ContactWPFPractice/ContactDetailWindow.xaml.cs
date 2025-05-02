using ContactWPFPractice.Model;
using SQLite;
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
using System.Windows.Shapes;

namespace ContactWPFPractice
{
    /// <summary>
    /// ContactDetailWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContactDetailWindow : Window
    {
        Contact contact;
        public ContactDetailWindow()
        {
            InitializeComponent();
            this.contact = contact;
            NameTextBox.Text = contact.Name;
            PhoneTextBox.Text = contact.Name;
            EmailTextBox.Text = contact.Name;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = NameTextBox.Text;
            contact.Phone = PhoneTextBox.Text;
            contact.Email = EmailTextBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = NameTextBox.Text;
            contact.Phone = PhoneTextBox.Text;
            contact.Email = EmailTextBox.Text;

            using(SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }
            Close();
        }
    }
}
