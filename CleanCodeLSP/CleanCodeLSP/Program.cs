namespace CleanCodeLSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 리스코프 치환 원칙
            // 부모 객체와 이를 상속한 자식 객체가 있을 때 부모 객체를 호출하는
            // 동작에서 자식 객체가 부모 객체를 완전히 대체할 수 있다.
            // 요점 : 부모 클래스에서 정해진 규약을 자식 클래스에서 어기면 안된다.
            Bird sparrow = new Sparrow();
            sparrow.MakeSound();
            ((IFlyable)sparrow).Fly();

            Bird penguin = new Penguin();
            penguin.MakeSound(); // THis will throw an exception
        }
    }

    public class Bird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
    }

    public class Penguin : Bird
    {

        public override void MakeSound()
        {
            base.MakeSound();
        }
    }

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
