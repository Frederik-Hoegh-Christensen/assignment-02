using Assignment2;

namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Return_Names_Using_LINQ()
    {
        // Arrange
        var names = Queries.ReturnNamesByRowlingLINQ();

        // Assert
        names.Should().BeEquivalentTo(new[] {"Albus Dumbledore", "Harry Potter", "Hermione Granger", "Minerva McGonagall", "Ronald Weasley", "Tom Riddle"});
    }

    [Fact]
    public void Return_Names_Using_Extension_Methods()
    {
        // Arrange
        var names = Queries.ReturnNamesByRowlingExtensionMethods();

        // Assert
        names.Should().BeEquivalentTo(new[] { "Albus Dumbledore", "Harry Potter", "Hermione Granger", "Minerva McGonagall", "Ronald Weasley", "Tom Riddle" });
    }

    [Fact]
    public void Return_Year_First_Sith_LINQ()
    {
        // Arrange
        var year = Queries.YearOfFirstSithLINQ();

        // Assert
        year.Should().Be(1977);
    }

    [Fact]
    public void Return_Year_First_Sith_Extension_Methods()
    {
        // Arrange
        var year = Queries.YearOfFirstSithExtensionMethods();

        // Assert
        year.Should().Be(1977);
    }

    [Fact]
    public void Unique_List_Of_Wizards_LINQ()
    {
        // Arrange
        var year = Queries.UniqueListOfWizardsLINQ();

        // Assert
        year.Should().BeEquivalentTo(new[] { ("Albus Dumbledore", 1997), ("Harry Potter", 1997), ("Ronald Weasley", 1997), ("Hermione Granger", 1997), ("Minerva McGonagall", 1997), ("Tom Riddle", 1998) });
    }

    [Fact]
    public void Unique_List_Of_Wizards_Extension_Methods()
    {
        // Arrange
        var year = Queries.UniqueListOfWizardsExtensionMethods();

        // Assert
        year.Should().BeEquivalentTo(new[] { ("Albus Dumbledore", 1997), ("Harry Potter", 1997), ("Ronald Weasley", 1997), ("Hermione Granger", 1997), ("Minerva McGonagall", 1997), ("Tom Riddle", 1998) });
    }

    [Fact]
    public void Wizards_Grouped_By_Creator_Reverse_OrderBy_Creator_And_Wizard_Name_LINQ()
    {
        // Arrange
        var wizards = Queries.WizardsGroupedByCreatorReverseOrderByCreatorAndWizardNameLINQ();

        // Assert
        wizards.Should().BeEquivalentTo(new[] { "Sauron", "Gandalf The White", "Gandalf The Grey", "Tom Riddle", "Ronald Weasley", "Minerva McGonagall", "Hermione Granger", "Harry Potter", "Albus Dumbledore", "Darth Vader" });
    }

    [Fact]
    public void Wizards_Grouped_By_Creator_Reverse_OrderBy_Creator_And_Wizard_Name_Extensions_Methods()
    {
        // Arrange
        var wizards = Queries.WizardsGroupedByCreatorReverseOrderByCreatorAndWizardNameExtensionMethods();

        // Assert
        wizards.Should().BeEquivalentTo(new[] { "Sauron", "Gandalf The White", "Gandalf The Grey", "Tom Riddle", "Ronald Weasley", "Minerva McGonagall", "Hermione Granger", "Harry Potter", "Albus Dumbledore", "Darth Vader" });
    }
}
