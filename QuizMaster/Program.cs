
namespace QuizMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write 'T' if the statement is true, and 'F' if it's false.");
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finished the test");
            }
        }

        static void StartQuiz()
        {
            List<string> questions = new List<string>
            {
                "Q1) Machine learning is a subset of artificial intelligence (AI)",
                "Q2) A VPN (Virtual Private Network) is used to create a secure and encrypted connection over the internet",
                "Q3) Wi-Fi is a brand name for a wireless networking standard",
                "Q4) The OSI model has ten layers",
                "Q5) An IP address is a unique identifier assigned to each device on a network"
            };
            List<string> answers = new List<string> { "T", "T", "F", "F", "T" };

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine(questions[i]);
                    string userAnswer = Console.ReadLine().ToUpper();

                    if (userAnswer == "T" || userAnswer == "F")
                    {
                        validInput = true;

                        if (userAnswer == answers[i].ToUpper())
                        {
                            Console.WriteLine("Great Job");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("The correct answer is: " + answers[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, make sure to enter 'F' or 'T'.");

                    }
                }

                Thread.Sleep(2000);
                continue;
            }

            if (score > 2)
            {
                Console.WriteLine("Your score is: " + score + "/" + questions.Count + " You're doing an excellent job");
            }
            else
            {
                Console.WriteLine("Your score is: " + score + "/" + questions.Count + " Best luck next time");
            }
        }
    }
}