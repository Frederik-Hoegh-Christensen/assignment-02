namespace Assignment2.Tests;
public class StudentTests
{
    [Fact]
    public void ToStringTest()
    {
        // Arrange
        Student s = new Student() {id= 1, givenName= "Selma", surName= "Bernild", startDate= new DateTime(2002,01,01), endDate= new DateTime(2002,01,01,01,01,01), graduationDate= new DateTime(2002,01,01,01,01,01)};

        // Act
        var result = s.ToString();

        //Assert
        Assert.Equal("1, Selma Bernild, StartDate: 01.01.2002 00.00.00", result);
    }

        [Fact]
    public void ImmutableStudentToStringTest()
    {
        // Arrange
        ImmutableStudent s = new ImmutableStudent (1, "Selma", "Bernild", Status.Active, new DateTime(2002,01,01), new DateTime(2002,01,01,01,01,01), new DateTime(2002,01,01,01,01,01));

        // Act
        var result = s.GivenName;

        //Assert
        Assert.Equal("Selma", result);
    }

        [Fact]
    public void ImmutableStudentEquals_Returns_TrueTest()
    {
        // Arrange
        ImmutableStudent s = new ImmutableStudent (1, "Selma", "Bernild", Status.Active, new DateTime(2002,01,01), new DateTime(2002,01,01,01,01,01), new DateTime(2002,01,01,01,01,01));
        ImmutableStudent t = new ImmutableStudent (1, "Selma", "Bernild", Status.Active, new DateTime(2002,01,01), new DateTime(2002,01,01,01,01,01), new DateTime(2002,01,01,01,01,01));
        // Act
        var result = t==s;

        //Assert
        Assert.True(result);
    }
        [Fact]
    public void ImmutableStudentEquals_Returns_FalseTest()
    {
        // Arrange
        ImmutableStudent s = new ImmutableStudent (1, "Selma", "Bernild", Status.Active, new DateTime(2002,01,01), new DateTime(2002,01,01,01,01,01), new DateTime(2002,01,01,01,01,01));
        ImmutableStudent t = new ImmutableStudent (1, "Emma", "Bernild", Status.Active, new DateTime(2002,01,01), new DateTime(2002,01,01,01,01,01), new DateTime(2002,01,01,01,01,01));
        // Act
        var result = t==s;

        //Assert
        Assert.False(result);
    }

}