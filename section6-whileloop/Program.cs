namespace section6_whileloop;

internal static class Program
{
    public static void Main(string[] args)
    {
        var guessingRound = 0;
        var randomizer = new Random();
        do
        {
            guessingRound++;
            Console.Write("Enter a number: ");
            var correctNumber = randomizer.Next(1, 5);
            var guessingNumber = Console.ReadLine();

            if (guessingNumber != null && int.Parse(guessingNumber) == correctNumber)
            {
                Console.WriteLine($"Congratulation! You win the game after {guessingRound} times of guessing.");
                Console.Write("Would you like to continue (Y or N)? ");
                var yesOrNo = Console.ReadLine();
                if (yesOrNo is "N")
                {
                    Console.WriteLine("Thanks for playing the game! Cya!");
                    break;
                }
                guessingRound = 0;
            }
            
            Console.WriteLine("Cleaning up the screen...");
            Thread.Sleep(2000);
            Console.Clear();
        } while (true);
    }
}