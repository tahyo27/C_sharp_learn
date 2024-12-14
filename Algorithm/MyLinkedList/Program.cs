namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, MyLinkedList!");

            MyLinkedList<int> list = new MyLinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
                
            list.Print();
        }
    }
}
