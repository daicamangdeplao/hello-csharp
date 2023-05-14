namespace section12_object;

internal static class Program
{
    public static void Main(string[] args)
    {
        var myFriend = new Friend("Joe", "Doe");

        Console.WriteLine(myFriend);

        var myNewFriend = new Friend("Jax", "Pax");
        
        Console.WriteLine(myNewFriend);

        myNewFriend = myFriend;
        
        Console.WriteLine(myFriend);
        Console.WriteLine(myNewFriend);
        
        myFriend.ChangeLastName("Jil");
        
        Console.WriteLine(myFriend);
        Console.WriteLine(myNewFriend);
    }
}