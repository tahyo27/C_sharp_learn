﻿using System.Data;
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
using ContactWPFPractice.Model;

namespace ContactWPFPractice;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Contact> contacts;
    public MainWindow()
    {
        InitializeComponent();
        contacts = new List<Contact>();
        ReadDataBase();
    }

    private void ReadDataBase()
    {
        List<Contact> contacts;
        using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
        {
            conn.CreateTable<Contact>();
            contacts = [.. (conn.Table<Contact>().ToList()).OrderBy(c => c.Name)];
        }
        if(contacts is not null)
        {
            contactList.ItemsSource = contacts;
        }
    }

    private void contactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Contact selectedContact = (Contact)contactList.SelectedIndex;
        if (selectedContact != null)
        {
            ContactDetailWindow contactDetailWindow = new ContactDetailWindow(selectedContact);
            contactDetailWindow.ShowDialog();
        }
        ReadDataBase();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        NewContactWindow newContactWindow = new NewContactWindow();
        newContactWindow.ShowDialog();

        ReadDataBase();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextBox searchTextBox = sender as TextBox;
        var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchTextBox.Text)).ToList();
    }
}