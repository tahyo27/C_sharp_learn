// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array App");

int[,] array2DDeclaration = new int[3, 3]; // [][] 랑 다르게 [,]으로 이차원 배열 선언
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3DDeclaration = new int[3, 3, 3];

int[,] array2DInizilized = { {1,2}, { 3, 4 } };

string[,,] simple3DArray =
{
    {
        {"000", "001" },
        { "010", "011"}
    },
    {
        {"100", "101" },
        {"110", "111" }
    }
};

// 자바랑 똑같이 가능 int[] myIntArray = new int[5];
int[] myIntArray = { 1, 2, 3, 4, 5 }; 

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