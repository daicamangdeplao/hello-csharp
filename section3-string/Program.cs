internal static class Program
{
    public static void Main(string[] args)
    {
        const string message = "Hello, World";
        
        // Check the length
        Console.WriteLine($"[{message}] has the length of {message.Length}");
        // Manipulate elements in a string
        Console.WriteLine($"The lower case of [{message}] is [{message.ToLower()}]");
        // Compare two strings
        Console.WriteLine(message.ToLower().Equals("hello, world"));
        // Access to a character in a string
        Console.WriteLine(message[0].ToString().Equals("H"));
        Console.WriteLine(message.ElementAt(0).ToString().Equals("H"));
        // Concatenate two strings
        Console.WriteLine("Hello" + ", World!");
        string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog." };
        Console.WriteLine(string.Join(" ", words));
    }
}