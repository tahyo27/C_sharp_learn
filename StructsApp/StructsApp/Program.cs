namespace StructsApp
{
    public struct Point
    {
        //int X { get; set; }
        //int Y { get; set; }
        public int X;
        public int Y;



        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point : {X}, {Y}");
        }
    }

    public struct PointTwo
    {
        public double X { get; }
        public double Y { get; }

        public PointTwo(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(PointTwo other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p3;
            p2.X = 10;
            p2.Y = 20;
            p2.Display();

            PointTwo p1 = new PointTwo(10, 20);
            p1.Display();

            PointTwo p2 = new PointTwo(20, 30);
            p2.Display();

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points: {distance:F5}");


            Console.ReadKey();
        }
    }
}
