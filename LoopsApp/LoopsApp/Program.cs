// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

Console.WriteLine("Loops App");

//do-while loop is a post-test loop
int currentScore = 0;
int sum = 0;
int counter = 0;
do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish");
    currentScore = int.Parse(Console.ReadLine());
    if(currentScore != -1)
    {
        sum = sum + currentScore;
    }
    
    counter++;
} while (currentScore != -1);

int average = sum / counter;
Console.WriteLine($"The average is {average}");


Console.ReadKey();
