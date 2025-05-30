﻿using System;
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
using DesktopContactsApp.Classes;
using SQLite;

namespace DesktopContactsApp
{
    /// <summary>
    /// NewContactsWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NewContactsWindow : Window
    {
        public NewContactsWindow()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Save Contact
            Contact contact = new Contact()
            {
                Name = NameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneNumberTextBox.Text,
            };
           

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }
                
            
            Close();
        }
    }
}
