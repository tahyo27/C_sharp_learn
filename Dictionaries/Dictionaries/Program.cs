namespace Dictionaries
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");

            // key - value
            Dictionary<int, string> employees = new Dictionary<int, string>();
            Dictionary<int, Employee> std = new Dictionary<int, Employee>();
                std.
            // Adding Items to a Dictionary
            std.Add(1, new Employee("kim", 35, 200000));
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Fob Smith");
            employees.Add(104, "Wob Smith");
            employees.Add(105, "Eob Smith");

            // access items in a dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // update data in a dictionary
            employees[102] = "Jane Smith";

            // remove an item from a dictionary
            employees.Remove(102);

            // Iterating over a dictionary
            foreach (KeyValuePair<int, string> kvp in employees)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }

            Console.ReadKey();
        }
    }
}
