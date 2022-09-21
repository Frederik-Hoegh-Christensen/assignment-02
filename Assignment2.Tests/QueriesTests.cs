using Assignment2;

namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var names = Queries.ReturnNamesByRowling();

        // Assert
        names.Should().BeEquivalentTo(new[] {"Albus Dumbledore", "Harry Potter", "Hermione Granger", "Minerva McGonagall", "Ronald Weasley", "Tom Riddle"});

    }
}
