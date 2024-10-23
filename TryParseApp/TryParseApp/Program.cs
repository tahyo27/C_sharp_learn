// See https://aka.ms/new-console-template for more information


// creating an instance of the Random Class
Random random = new Random();
int randomNumber = random.Next(1, 11);

Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;
bool isNumber = int.TryParse(inputString, out num1);
if(isNumber)
{
    if(num1 == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong, try again!");
    }
    Console.WriteLine("Well done, you entered a number");
}
else
{
    Console.WriteLine("Haha you troll. You should've enteed a number");
}
Console.WriteLine($"User enterd number + 1 {num1}");

Console.ReadKey();
