namespace Assignment2.Tests;

public class QueriesTests
{
    IEnumerable<Wizard> wizardCollection = WizardCollection.Create();

    [Fact]
    public void GetRowlingWizards_Given_Stream_Of_Wizards_Returns_Names_Of_Wizards_By_Rowling()
    {
        // Arrange
        var expected = new[]
        {
            "Harry Potter",
            "Bellatrix Lestrange",
            "Sirius Black",
            "Remus Lupin",
            "Hermione Granger",
            "Lord Voldemort",
            "Professor McGonagall",
            "Professor Snape",
            "Professor Dumbledore",
            "Mad-Eye Moody",
        };

        // Act
        var actualLINQ = Queries.GetRowlingWizardsOne(wizardCollection);
        var actualExtension = Queries.GetRowlingWizardsTwo(wizardCollection);

        // Assert
        Assert.Equal(expected, actualLINQ);
        Assert.Equal(expected, actualExtension);
    }

    [Fact]
    public void GetFirstSithLordYear_Given_Stream_Of_Wizards_Returns_Year_Of_First_Sith_Lord()
    {
        // Arrange
        var expected = 1977;

        // Act
        var actualLINQ = Queries.GetFirstSithLordYearOne(wizardCollection);
        var actualExtension = Queries.GetFirstSithLordYearTwo(wizardCollection);

        // Assert
        Assert.Equal(expected, actualLINQ);
        Assert.Equal(expected, actualExtension);
    }

    [Fact]
    public void GetUniqueRowlingWizards_Given_Stream_Of_Wizards_Returns_Name_And_Year_Of_Unique_Wizards()
    {
        // Arrange
        IEnumerable<(string, int?)> expected = new List<(string, int?)>()
        {
            ("Harry Potter", 1997),
            ("Bellatrix Lestrange", 1997),
            ("Sirius Black", 1997),
            ("Remus Lupin", 1997),
            ("Hermione Granger", 1997),
            ("Lord Voldemort", 1997),
            ("Professor McGonagall", 1997),
            ("Professor Snape", 1997),
            ("Professor Dumbledore", 1997),
            ("Mad-Eye Moody", 1997),
        };

        // Act
        var actualLINQ = Queries.GetUniqueRowlingWizardsOne(wizardCollection);
        var actualExtension = Queries.GetUniqueRowlingWizardsTwo(wizardCollection);

        // Assert
        Assert.Equal(expected, actualLINQ);
        Assert.Equal(expected, actualExtension);
    }

    [Fact]
    public void GetWizardsByCreator_Given_Stream_Of_Wizards_Returns_Wizards_By_Creator_Reversed()
    {
        // Arrange
        IEnumerable<(string, IEnumerable<string>)> expected = new List<(string, IEnumerable<string>)>()
        {
            ("T.A. Barron", new[]
            {
                "Merlin",
            }),
            ("Stephen King", new[]
            {
                "Carrie",
            }),
            ("J.R.R. Tolkien", new[]
            {
                "Sauron",
                "Gandalf",
            }),
            ("J.K. Rowling", new[]
            {
                "Harry Potter",
                "Bellatrix Lestrange",
                "Sirius Black",
                "Remus Lupin",
                "Hermione Granger",
                "Lord Voldemort",
                "Professor McGonagall",
                "Professor Snape",
                "Professor Dumbledore",
                "Mad-Eye Moody",
            }),
            ("George Lucas", new[]
            {
                "Darth Vader",
            }),
        };

        // Act
        var actualLINQ = Queries.GetWizardsByCreatorOne(wizardCollection);
        
        var actualExtension = Queries.GetWizardsByCreatorTwo(wizardCollection);

        // Assert
        Assert.Equal(expected, actualLINQ);
        Assert.Equal(expected, actualExtension);
    }
}
