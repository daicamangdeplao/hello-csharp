using System.Text;

namespace section14_relationship;

public class ClassRoom
{
    private List<Friend> friends;

    public ClassRoom(List<Friend> friends)
    {
        this.friends = friends;
    }

    public int NumberOfFriends => friends.Capacity;

    public void AddFriend(Friend newFriend)
    {
        friends.Add(newFriend);
    }

    public void RemoveFriend(string fullName)
    {
        friends = friends.Where(friend => !friend.FullName.Equals(fullName)).ToList();
    }

    public override string ToString()
    {
        var friendNames = friends.Aggregate(new StringBuilder(), (collector, friend) =>
        {
            if (collector.Length > 0)
            {
                collector.Append(", ");
            }

            collector.Append(friend.FullName);
            return collector;
        });
        return $"{{[{friendNames}]}}";
    }
}