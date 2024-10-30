namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany", 
                new string[] {"Paris", "Berlin", "London", "Madrid"},
                1
                ),
                new Question("What is 2 + 2 ?",
                new string[] {"3", "4", "5", "6"},
                1
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion( questions[0] );
            Console.ReadLine();
        }
    }
}
