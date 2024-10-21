// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char myFavoriteCharacter = '@';


//implicitely typed variable
var myFavoriteGenre = "LitRPGs";

var myFavoriteNumber = 13;

var yourFavoritNumber = 14;

int ourNumbersCombined = myFavoriteNumber + yourFavoritNumber;

var ourNumbersCombined2 = myFavoriteNumber + yourFavoritNumber;

//Referency Type
// explicitely typed variable
string myName = "Dennis";

// defining or setting up a variable
string petsName;

//initialize variable
petsName = "Daisy";
Console.WriteLine($"my pet is {petsName}"); //자바스크립트 사용법과 유사

petsName = "Barky";
Console.WriteLine($"my pet is {petsName}");

//Operators and Order of Evaluation
int num1 = 5;
int num2 = 10;

Console.WriteLine("Addition num1 + num2 = " + (num1 + num2));
Console.WriteLine($"Addition num1 + num2 = {num1 + num2}" ); // 역시 이런식으로 계산되네
Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));
Console.WriteLine("Multiplication num1 * num2 = "+ (num1 * num2));
Console.WriteLine("Division num1 * num2 = " + (num1 / num2));

Console.WriteLine("first {0}, second {1}, third {2}", num1, num2, (num1 + num2)); //이런식으로 사용하는 방법도 존재



Console.ReadKey();