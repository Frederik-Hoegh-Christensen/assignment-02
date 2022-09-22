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
        var result = ys.Where(x => x % 7 == 0).Where(x => x > 42);

        // Assert
        result.Should().BeEquivalentTo(new[] { 315, 234332});
    }

    [Fact]
    public void Find_Leap_Years_Test()
    {
        // Arrange
        int[] ys = {1, 2, 3, 4, 5, 1992, 2001, 2022, 2032, 2141};

        // Act
        var result = ys.Where(x => DateTime.IsLeapYear(x));

        // Assert
        result.Should().BeEquivalentTo(new[] { 4, 1992, 2032 });
    }


    [Fact]
    public void Check_If_Uri_Is_Secure()
    {
        // Arrange
        Uri uri = new Uri("https://stackoverflow.com/questions/20679016/how-to-check-if-a-given-url-is-http-or-https-in-c-sharp");

        // Act
        var result = uri.IsSecure();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Count_Words_In_String()
    {
        // Arrange
        string temp = "There should be five words";

        // Act
        var result = temp.WordCount();

        // Assert
        result.Should().Be(5);
    }
}
