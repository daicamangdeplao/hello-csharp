namespace section12_object;

public class Friend
{
    private string _firstName;
    private string _lastName;

    public Friend(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName => $"{_firstName} {_lastName}";

    public override string ToString()
    {
        return $"{{{FullName}}}";
    }
    
    public void ChangeFirstName(string newFirstName)
    {
        _firstName = newFirstName;
    }

    public void ChangeLastName(string newLastName)
    {
        _lastName = newLastName;
    }
}