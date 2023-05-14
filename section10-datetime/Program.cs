namespace section10_datetime;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DateOnly.FromDateTime(DateTime.Now));
        Console.WriteLine(TimeOnly.FromDateTime(DateTime.Now));
        Console.WriteLine(TimeZoneInfo.Local);
        Console.WriteLine(TimeZoneInfo.Utc);
        
        var theEndOfAYear = new DateTime(2023, 12, 31);
        var theEve = theEndOfAYear.AddDays(1);
        Console.WriteLine(theEve);
        var christmas = theEndOfAYear.Subtract(TimeSpan.FromDays(6));
        Console.WriteLine(christmas);

        var universalTime = theEve.ToUniversalTime();
        Console.WriteLine(universalTime);
    }
}