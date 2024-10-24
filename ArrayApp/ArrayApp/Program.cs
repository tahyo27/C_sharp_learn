// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array App");

// 자바랑 똑같이 가능 int[] myIntArray = new int[5];
int[] myIntArray = [1, 2, 3, 4, 5]; // 자바랑 괄호가 다름

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine("Lenght of the weekdays Array is: " + weekDays.Length); // 렝스 대문자

for(int i = 0; i < weekDays.Length; i++)
{
    Console.WriteLine(weekDays[i]);
}

foreach(string item in weekDays) //var로도 가능
{
    Console.WriteLine(item);
}

Console.ReadKey();