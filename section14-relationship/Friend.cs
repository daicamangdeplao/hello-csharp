namespace section14_relationship;

public class Friend
{
    private readonly string _firstName;
    private readonly string _lastName;
    public string FullName => $"{_firstName} {_lastName}";

    public Friend(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}