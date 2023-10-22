namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 6;
            Console.WriteLine($"Hello, try guessing what my favorite number is.");
            string input = Console.ReadLine();
            var userGuess = int.Parse(input);

            if (userGuess < favNumber)
            {
                 Console.WriteLine(" Too Low. ");
            }
            else if (userGuess > favNumber)
            {
                 Console.WriteLine(" Too High. ");
            }
            else
            {
                 Console.WriteLine(" That is correct! ");
            }
        }
    }
}
