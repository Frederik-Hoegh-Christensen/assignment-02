using System.Collections.Generic;

namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_Numbers_In_xs()
    {
        // Arrange
        IEnumerable<int>[] xs = new[] { new[] { 1, 2 }, new[] { 3, 4 } };

        // Act
        var result = xs.SelectMany(x => x);

        // Assert
        result.Should().BeEquivalentTo(new[] { 1, 2, 3, 4 });

    }

    [Fact]
    public void Select_Numbers_In_ys_Divisible_By_7_Greater_Than_42()
    {
        // Arrange
        int[] ys = { 1, 2, 3, 7, 14, 15, 42, 43, 44, 45, 315, 514, 234332 };

        // Act
        var result = ys.Divisble_By_7_Greater_Than_42();

        // Assert
        result.Should().BeEquivalentTo(new[] { 315, 234332});
    }

    [Fact]
    public void Find_Leap_Years_Test()
    {
        // Arrange
        int[] ys = {1, 2, 3, 4, 5, 1992, 2001, 2022, 2032, 2141};

        // Act
        var result = ys.Find_Leap_Years();

        // Assert
        result.Should().BeEquivalentTo(new[] { 4, 1992, 2032 });
    }
}
