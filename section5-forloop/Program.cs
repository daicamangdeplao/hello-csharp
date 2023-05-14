namespace section5_forloop;

internal static class Program
{
    public static void Main(string[] args)
    {
        string[] friends = { "foo", "bar", "baz" };

        foreach (var friend in friends)
        {
            Console.Write($"{friend} ");
        }
        Console.WriteLine();

        var newFriends = friends.Append("qux");
        foreach (var friend in newFriends)
        {
            Console.Write($"{friend} ");
        }

        Console.WriteLine();
        var indexOfFoo = Array.IndexOf(friends, "foo");
        friends[indexOfFoo] = "newFoo";
        foreach (var friend in friends)
        {
            Console.Write($"{friend} ");
        }
    }
}