// Methods are structured like this
// modifier returnType MoethodName(Parameters) {
// code block
// }

//Definition of a void method that returns nothing

void myFirstMethod()
{
    Console.WriteLine("MyFistMethod was called");
}

//Calling a Method
myFirstMethod();


Console.WriteLine("This is outside of the method");

string tmp = "This is temp string";
void WriteSomethingSpecific(string str) //C# 펑션은 이름 앞에 대문자 쓰는듯
{
    Console.WriteLine($"This is writeSomethingSepecific str is {str}");
}
WriteSomethingSpecific(tmp);

int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}
int myResult = AddTwoValues(5, 10);
Console.WriteLine($"The result is {myResult}");

Console.ReadKey();