using DesktopContactsApp.Classes;
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

namespace DesktopContactsApp
{
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
            ReadDatabase();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewContactsWindow newContactsWindow = new NewContactsWindow();
            newContactsWindow.ShowDialog();

            ReadDatabase();
        }

        private void ReadDatabase()
        {
            List<Contact> contacts;
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn.Table<Contact>().ToList();
            }

            if(contacts != null)
            {
                //foreach(var c in contacts)
                //{
                //    contactListView.Items.Add(new ListViewItem
                //    {
                //        Content = c
                //    });
                //}
                contactListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;

            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchTextBox.Text)).ToList();
        }
    }
}