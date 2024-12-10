namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentByAge();
            um.AllStudentsFromBeijingTech();
            um.AllStudentsFromThatUni(1);

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedInts2 = from i in someInts orderby i descending select i;

            foreach (int i in reversedInts2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
    
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1});
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1});
            students.Add(new Student { Id = 2, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2});
            students.Add(new Student { Id = 2, Name = "James", Gender = "male", Age = 25, UniversityId = 2});
            students.Add(new Student { Id = 2, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2});
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students:");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            var bjtStudents = from student in students join university in universities on student.UniversityId equals university.Id
                              where university.Name == "Beijing Tech"
                              select student;

            Console.WriteLine("Students from Beijing Tech");
            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            var myStudents = from student in students
                             join university in universities on student.UniversityId equals university.Id
                             where university.Id == Id
                             select student;

            Console.WriteLine($"Students from that uni {Id} ");
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {Name} with id {Id}");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender} and Age {Age} from University with the Id {UniversityId}");
        }
    }

}
