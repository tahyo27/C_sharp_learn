namespace CleanCodeDIP
{
    internal class Program
    {
        //DIP 
        // 추상화에 의존해야지 구체화에 의존하면 안된다
        //자신보다 변화하기 쉬운 것을 의존해서는 안 되고, 거의 변화가 없는 개념에 의존해야 한다
        static void Main(string[] args)
        {
            IEmailService emailService = new EmailService();
            Notification notification = new Notification(emailService);
            notification.Send("Hello, this is a test notification");
        }
    }

    public interface IEmailService
    {
        public void SendEmail(string to, string subject, string body);
    }

   public class EmailService : IEmailService
   {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject {subject}");
        }
   }

    public class Notification
    {
        private readonly IEmailService _emailService;
        //private readonly EmailService _emailService;

        //public Notification() 이렇게 상위가 구체적인것에 의존하면 안됨
        //{
        //    _emailService = new EmailService();
        //}
        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public void Send(string message)
        {
            _emailService.SendEmail("user@example.com", "Notification", message);
        }
    }

}
