using FluentAssertions;
using Xunit;

namespace Rent.Core.Tests;

public class TestCustomerAnnouncement
{
    [Fact]
    public void It_should_announce()
    {
        var customer = Customer.Create();

        customer.Announce();

        customer.Announcements.Should().NotBeEmpty();
    }
}