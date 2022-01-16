namespace Rent.Core;

public class Customer
{
    public List<Announcement> Announcements { get; private set; } = null!;

    public static Customer Create()
    {
        var customer = new Customer
        {
            Announcements = new List<Announcement>()
        };

        return customer;
    }

    public void Announce()
    {
        var announcement = Announcement.Create();

        Announcements.Add(announcement);
    }
}