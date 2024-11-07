namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();
            Console.WriteLine("Inheritance App!");
            
        }
    }

    // Base Class ( Parent Class or Superclass)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking.....");
        }
    }

    // A breed of dog
    class Cat : Animal
    {
        public void Miau()
        {
            Console.WriteLine("Cat is meowing");
        }
    }

}
