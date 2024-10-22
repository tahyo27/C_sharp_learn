using System.Security.Cryptography;

namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch 문");
            int month = 5;
            string monthName;
            switch(month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                default:
                    monthName = "Unknown";
                    break;
            }



            Console.WriteLine("Logic");

            int number1 = 0;
            int number2 = 0;

            bool isEqual = number1 == number2;

            bool isNotEqual = number1 != number2;

            Console.WriteLine("Please enter a number");

            if(number1 == int.Parse(Console.ReadLine())) {
                Console.WriteLine("Numbers are equal!");
            }
            else
            {
                Console.WriteLine("Numbers are not equal!");
            }



            int num1 = 5;
            int num2 = 6;

            //relational operator > < <= >= 
            bool isHiger = num1 > num2;
            
            int age = 0;
            bool isWithParents = false;
            Console.WriteLine("Please enter a age");
            age = int.Parse(Console.ReadLine());
           

            if(age > 18)
            {
                Console.WriteLine("Go party in the club!");
            }
            else if (age > 18 && isWithParents)
            {
                Console.WriteLine("Go party in the club with your parents");
            }
            else if(age >= 13)
            {
                Console.WriteLine("Are you with your parents? Answer with y or n");
                string isWithParentsString = Console.ReadLine();
                if(isWithParentsString == "y")
                {
                    Console.WriteLine("Go party in the party with your parents");
                } else
                {
                    Console.WriteLine("No party for you today");
                }
            }
            else if(age > 6)
            {
                Console.WriteLine("Go party in school");
            }
            else
            {
                Console.WriteLine("Go party in Kindergarden");
            }





            bool isRainy = false;
            bool hasUmbrella = true;
            //Logical Operators
            //AND &&
            //OR ||
            //NOT !

            //Variants of OR statements
            // true  || true -> true
            // true  || false -> true
            // false || true -> true
            // false || false -> false


            //Variants of AND operator/statements
            // true  && true -> true
            // true  && false -> false
            // false && true -> flase
            // false && false -> false

            if (isRainy && hasUmbrella) {
                Console.WriteLine("I'm protected against rain");
            }

            Console.WriteLine("I'm ok");
            Console.ReadKey();
        }
    }
}
