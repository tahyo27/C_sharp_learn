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
using DesktopContactsAppPrac.Classes;
using SQLite;

namespace DesktopContactsAppPrac
{
    /// <summary>
    /// ContactDetailsWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        Contact contact;
        internal ContactDetailsWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            nameTextBox.Text = contact.Name;
            phoneTextBox.Text = contact.Phone;
            emailTextBox.Text = contact.Email;
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = nameTextBox.Text;
            contact.Phone = phoneTextBox.Text;
            contact.Email = emailTextBox.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                conn.Update(contact);
            }
            Close();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                conn.Delete(contact);
            }
            Close();
        }
    }
}
