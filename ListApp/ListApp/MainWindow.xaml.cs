using ListApp.DataBinding;
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

namespace ListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        { 
            new Person{ Name = "John", Age = 30},
            new Person{ Name = "Park", Age = 20},
            new Person{ Name = "Kim", Age = 34},
            new Person{ Name = "Kang", Age = 26},
            new Person{ Name = "Hong", Age = 29},
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                Person person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}