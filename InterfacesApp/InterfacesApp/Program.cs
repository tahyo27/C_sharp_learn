namespace InterfacesApp
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal payment of {amount}");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog ate {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark...");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Cat ate {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow~~");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Cat cat = new Cat();
            cat.Eat("fish");
            cat.MakeSound();

            IPaymentProcessor creditCard = new CreditCardProcessor();
            PaymentService service = new PaymentService(creditCard);
            service.ProcessOrderPayment(100.00m);

            IPaymentProcessor paypal = new PaypalProcessor();



        }
    }
}
