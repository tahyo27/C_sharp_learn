namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.MakeSound();
            Console.WriteLine("Inheritance App!");

            Employee joe = new Employee("Joe", 36);
            joe.DisplayPersonInfo();


            Console.ReadKey();
            string name = "";
            
        }
    }

    // Base Class ( Parent Class or Superclass)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking.....");
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }

    }

    // A breed of dog
    class Cat : Animal
    {
        public void Miau()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

    public class Person
    {
        public String Name { get; set; }

        public int Age {  get; set; } 
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called ");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID)
             : base(name, age) // Calling the base class constructor
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }

}
