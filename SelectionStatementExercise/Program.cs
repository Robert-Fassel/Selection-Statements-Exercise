namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            var counter = 0;
            do
            {
                Console.WriteLine("Pick a number from 1 - 1000");

                userInput = int.Parse(Console.ReadLine());


                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }

                counter++;

                Console.WriteLine($" you have guessed {counter} time(s)");
            } while (userInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "algebra":
                    Console.WriteLine("I hate Math!");
                    break;
                case "science":
                    Console.WriteLine("I love Science");
                    break;
                case "pe":
                case "gym":
                    Console.WriteLine("PE is the best");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }
        }
    }
}
