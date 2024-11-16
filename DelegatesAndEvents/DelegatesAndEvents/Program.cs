namespace DelegatesAndEvents
{
    public delegate int Comparison<T>(T x, T y);

    public delegate void LogHandler(string message);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for(int i = 0; i < people.Length -1; i++)
            {
                for(int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }

        }
    }
    internal class Program
    {


        public class Logger
        {
            public void LogToConsoe(string message)
            {
                Console.WriteLine($"Console Log : {message}");
            }

            public void LogToFile(string message)
            {
                Console.WriteLine("File Log: " + message);
            }
        }

        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            Notify notifyDelgate = ShowMessage;

            notifyDelgate("Hello Delegates!");

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsoe;
            logHandler("Logging to console");

            logHandler += logger.LogToFile;
            logHandler("Logging to File");

            Person[] people =
            {
                new Person {Name = "Alice", Age = 30 },
                new Person {Name = "John", Age = 25 },
                new Person {Name = "Charlie", Age = 35}
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach (Person person in people)
            {
                Console.WriteLine($">>>>>>>>> Name : {person.Name}, Age : {person.Age}");
            }

            InvokeSafely(logHandler, "After removing LogToFile");
           // logHandler("After removing LogToFile");

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }


        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if(tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }


    }
    
}
