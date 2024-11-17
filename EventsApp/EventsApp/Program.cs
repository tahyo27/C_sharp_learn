namespace EventsApp
{

    public delegate void Notify(string message);

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> Changed;
       // public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                if (_temperature != value)
                {
                    // Raise Event
                    OnTemperatureChangedEvent(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }
        protected virtual void OnTemperatureChangedEvent(TemperatureChangedEventArgs e)
        {
            Changed?.Invoke(this, e);
        }
    }

        

        public class TemperatureAlert
        {
            public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
            {
                Console.WriteLine($"Alert : temperature is {e.Temperature} sender is : {sender}" );
            }
        }

    public class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }
    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised;

            publisher.RaiseEvent("test");

            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();
            TemperatureAlert temperatureAlert = new TemperatureAlert();
            temperatureMonitor.Changed += temperatureAlert.OnTemperatureChanged;

            temperatureMonitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            temperatureMonitor.Temperature = int.Parse(Console.ReadLine());



            Console.ReadKey();
        }
    }
}
