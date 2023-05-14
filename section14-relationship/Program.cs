namespace section14_relationship;

internal static class Program
{
    public static void Main(string[] args)
    {
        var classRoom = new ClassRoom(new List<Friend>()
        {
            new("Jax", "Pax"), 
            new("Joe", "Doe"), 
            new("Jil", "Gil") 
        });
        
        Console.WriteLine(classRoom);
        
        classRoom.AddFriend(new("Dee", "Jee"));
        classRoom.RemoveFriend("Jil Gil");
        
        Console.WriteLine(classRoom);
    }
}