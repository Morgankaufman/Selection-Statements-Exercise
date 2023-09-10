namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 43;
            var guessedCorrectly = false;

            while (!guessedCorrectly)
            {

                Console.WriteLine("Guess a number");

                var userInput = Console.ReadLine();


                if (int.TryParse(userInput, out int userGuess))
                {

                    if (userGuess == favNumber)
                    {
                        Console.WriteLine("awesome! thats right!");
                        guessedCorrectly = true;

                    }

                    else if (userGuess > favNumber)
                    {
                        Console.WriteLine("Too high");
                    }
                    else
                    {
                        Console.WriteLine("Too low");
                    }


                }
                else
                {
                    Console.WriteLine("invalid number guess again");
                }
            }
        }
    }
}

