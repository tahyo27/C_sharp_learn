namespace ClassesApp
{
    // Access Modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes App");

            /*
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            // Console.WriteLine("Please enter the Brand name");
            // "SETTING BRAND"
            audi.Brand = "Audi";

            // "GETTING BRAND"
            Console.WriteLine($"Brand is {audi.Brand}");
            Console.WriteLine($"Brand is {bmw.Brand}");
            */
            /*
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet 1", "5551234567");

            Console.WriteLine($"Name of Customer is {earl.Name}");
            Customer myCustomer = new Customer();
            Console.WriteLine("Details about customer" + myCustomer.Name);
            */
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Customer myCustomer = new Customer();
            myCustomer.SetDetails("Frank", "Mainstreet2", "555121312");

            Console.ReadKey();
            

        }
    }
}
