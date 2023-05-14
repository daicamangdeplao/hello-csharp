namespace section4_ifstatement;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your choice: ");
        var userInput = Console.ReadLine();

        if (userInput != null && userInput.All(char.IsNumber))
        {
            Console.WriteLine("You input a numeric value");
        }
        else
        {
            Console.WriteLine("Your input is not clear");
        }
    }
}