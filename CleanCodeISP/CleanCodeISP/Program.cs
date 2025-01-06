namespace CleanCodeISP
{
    internal class Program
    {
        //ISP 원칙 클라이언트가 자신이 사용하지 않는 메서드에 의존하지 않도록 분리
        // 즉 하나의 큰 인터페이스 보다는 여러개의 작은 인터페이스를 사용
        static void Main(string[] args)
        {
            IWorkable worker = new Worker();
            worker.Work();
            ((IEatable)worker).Eat();

            IWorkable robot = new Robot();
            robot.Work();

        }
    }

    //public interface IWorker
    //{
    //    void Work();
    //    void Eat();
    //}

    public class Worker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public interface IEatable
    {
        void Eat();
    }

    public interface IWorkable
    {
        void Work();
    }
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }

        //public void Eat()
        //{
        //    // 로봇은 먹을 수 없다 .
        //    throw new NotImplementedException();
        //}
    }
}

