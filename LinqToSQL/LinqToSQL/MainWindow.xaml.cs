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

using System.Configuration;
using LinqToSQL.TestDBDataSetTableAdapters;

namespace LinqToSQL
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqTosqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.TestDBConnectionString"].ConnectionString;
            dataContext = new LinqTosqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            InsertStudent();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("DELETE FROM University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.University.InsertOnSubmit(yale);

            University beijingTech = new University();
            beijingTech.Name = "Beijing Tech";
            dataContext.University.InsertOnSubmit(beijingTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.University;
        }

        public void InsertStudent()
        {
            University yale = dataContext.University.First(un => un.Name.Equals("Yale"));
            University beijingTech = dataContext.University.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "male", University = yale});
            students.Add(new Student { Name = "Leyle", Gender = "female", UniversityId = beijingTech.Id });
            students.Add(new Student { Name = "James", Gender = "trans-gender", University = beijingTech });

            dataContext.Student.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Student;
        }
    }
}
