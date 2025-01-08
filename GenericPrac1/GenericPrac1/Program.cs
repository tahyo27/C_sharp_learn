namespace GenericPrac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box<int> box = new Box<int>();
            //box.Content = 1;
            //Console.WriteLine(box.Log());

            //Box<string> boxStr = new Box<string>();
            //boxStr.Content = "Hello World";
            //Console.WriteLine(boxStr.Log());

            Box<string> boxStr = new Box<string>("Hello World");
            boxStr.UpdateContent("Teaching C# is fun");
            Console.WriteLine(boxStr.GetContent());

            //TFirst, TSecond
            Slot<int, string> slot = new Slot<int, string>(100, "one hundred");
            slot.Display();

            Logger logger = new Logger();

            // 제네릭 메서드
            logger.Log<int>(10);
            logger.Log(20);
            logger.Log<string>("Hello World~");
            logger.Log("Hello Test World"); // <> 타입 지정 안해도 됨
            logger.Log(new { Name = "John", Age = 30 });


            // 인터페이스 제약조건 주는 부분
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product);

            // 제네릭 메서드 제약
            //Comparer.AreEqual(1, 1);
            var productTwo = new Product();
            var result = Comparer.AreEqual(product, productTwo);
            Console.WriteLine("제네릭 메서드 제약 결과값 : " + result);
        }
    }
    class Product : IEntiry
    {
        public int ID { get; }
    }
}
