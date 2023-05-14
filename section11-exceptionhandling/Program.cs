namespace section11_exceptionhandling;

internal static class Program
{
    public static void Main(string[] args)
    {
        DoSomething();
    }

    private static void DoSomething()
    {
        throw new MyException("Hello, World");
    }
}