﻿// See https://aka.ms/new-console-template for more information

//출력
Console.WriteLine("Enter a whole number!");

//변수 선언
int myNumber = 0;
int myNumber2 = 0;

string userInput = Console.ReadLine();
//Console.WriteLine("myNumber = " + myNumber); //${"" {} } 보간 방식은 컴파일할때 문자열로 변환

myNumber = int.Parse(userInput);

Console.WriteLine("Enter a whole number!");

userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);

int sum = myNumber + myNumber2;

//유저 인풋 받음 java 버퍼드리더 라이터랑 비슷한듯
Console.WriteLine($"The result of myNumber {myNumber} and myNumber2 {myNumber2} is {sum}");
Console.ReadKey();

