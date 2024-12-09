﻿namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();

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
