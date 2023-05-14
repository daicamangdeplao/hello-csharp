namespace section7_collection;

internal static class Program
{
    public static void Main(string[] args)
    {
        var arrayFriends = new string[] { "foo", "bar", "baz" };
        var listFriends = new List<string>() { "foo", "bar", "baz" };
        var dictFriends = new Dictionary<string, string>()
        {
            { "1", "foo" },
            { "2", "bar" },
            { "3", "baz" }
        };

        // array
        arrayFriends = arrayFriends.Append("foe").ToArray();
        Console.WriteLine($"My array friends: {string.Join(" ", arrayFriends)}");
        arrayFriends = arrayFriends.Where(friend => !friend.Equals("foe")).ToArray();
        var index = Array.IndexOf(arrayFriends, "baz");
        arrayFriends[index] = "qux";
        Console.WriteLine($"My array friends: {string.Join(" ", arrayFriends)}");
        //---
        
        // list
        listFriends = listFriends.Append("foe").ToList();
        Console.WriteLine($"My list friends: {string.Join(" ", listFriends)}");
        listFriends = listFriends.Where(friend => !friend.Equals("foe")).ToList();
        Console.WriteLine($"My list friends: {string.Join(" ", listFriends)}");
        index = listFriends.IndexOf("baz");
        listFriends[index] = "qux";
        Console.WriteLine($"My list friends: {string.Join(" ", listFriends)}");
        //---
        
        // dict
        dictFriends.Add("4", "foe");
        PrintDictionary(dictFriends);
        dictFriends = dictFriends.Where(pair => !pair.Value.Equals("foe"))
            .ToDictionary(keyValuePair => keyValuePair.Key, keyValuePair => keyValuePair.Value);
        PrintDictionary(dictFriends);
        var key = dictFriends.First(pair => pair.Value.Equals("baz")).Key;
        dictFriends[key] = "qux";
        PrintDictionary(dictFriends);
        //---
    }

    private static void PrintDictionary(Dictionary<string, string> dict)
    {
        Console.WriteLine("Key-Value pair:");
        foreach (var (key, value) in dict)
        {
            Console.WriteLine($"{{{key}-{value}}}");
        }
    }
}