namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }


            //double averageTemp = CalculateAverage(temperature);
            Console.WriteLine($"Average Temperatrue is : {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was : {temperature.Max()}");
            Console.WriteLine($"The min temp was : {temperature.Min()}");
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;
            for(int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            //temperature.Length is the amount of items inseide of temperature
            double average = sum / temperature.Length;
            return average;
        }
    }
}
