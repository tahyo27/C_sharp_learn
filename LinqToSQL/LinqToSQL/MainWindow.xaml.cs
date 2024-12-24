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
            //InsertStudent();
            //Insertlectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfToni();
            GetLectureFromToni();
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
        public void Insertlectures()
        {
            dataContext.Lecture.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lecture.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lecture;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Student.First(item => item.Name.Equals("Carla"));
            Student Toni = dataContext.Student.First(item => item.Name.Equals("Tonie"));
            Student Leyle = dataContext.Student.First(item => item.Name.Equals("Leyle"));
            Student Jame = dataContext.Student.First(item => item.Name.Equals("James"));

            Lecture Math = dataContext.Lecture.First(item => item.Name.Equals("Math"));
            Lecture History = dataContext.Lecture.First(item => item.Name.Equals("History"));

            dataContext.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Math });

            StudentLecture slToni = new StudentLecture();
            slToni.Student = Toni;
            slToni.LectureId = History.Id;
            dataContext.StudentLecture.InsertOnSubmit(slToni);

            dataContext.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLecture;
        }

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Student.First(item => item.Name.Equals("Tonie"));

            University ToniUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(ToniUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLectureFromToni()
        {
            Student Toni = dataContext.Student.First(item => item.Name.Equals("Tonie"));

            var tonisLectures = from sl in Toni.StudentLecture select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;
        }
    }
}
