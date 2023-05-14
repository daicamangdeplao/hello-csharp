namespace section11_exceptionhandling;

public class MyException : Exception
{
    public MyException(string msg) : base(msg) {}
}