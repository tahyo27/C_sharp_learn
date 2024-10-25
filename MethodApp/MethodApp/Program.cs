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
void writeSomethingSpecific(string str)
{
    Console.WriteLine($"This is writeSomethingSepecific str is {str}");
}
writeSomethingSpecific(tmp);
Console.ReadKey();