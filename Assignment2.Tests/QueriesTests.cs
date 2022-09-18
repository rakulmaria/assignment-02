namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void WizardCollection_With_Rowling()
    {
        var wizards = WizardCollection.Create();
        var expected = new List<string> {"Harry Potter","Ron","Hermione","Dumbledore"};
        Assert.Equal(expected, Queries.QueryOne(wizards));
        
    }
    [Fact]
    public void WizardCollection_With_Rowling2()
    {
        var wizards = WizardCollection.Create();
        var expected = new List<string> {"Harry Potter","Ron","Hermione","Dumbledore"};
        Assert.Equal(expected, Queries.QueryOneExtensionMethod(wizards));
        
    }

    [Fact]
    public void WizardCollection_With_Darth()
    {
        var wizards = WizardCollection.Create();
        var expected = 1977;
        Assert.Equal(expected, Queries.QueryTwo(wizards));
        
    }
     [Fact]
    public void WizardCollection_With_Darth2()
    {
        var wizards = WizardCollection.Create();
        var expected = 1977;
        Assert.Equal(expected, Queries.QueryTwoExtensionMethod(wizards));
        
    }
     [Fact]
    public void WizardCollection_With_Unique_Wizards()
    {
        var wizards = WizardCollection.Create();
        var expected = new List<(string,int)> {("Harry Potter",2020),("Ron",2020),("Hermione",2020),("Dumbledore",2020)};
        Assert.Equal(expected, Queries.QueryThree(wizards));
        
    }
     [Fact]
    public void WizardCollection_With_Unique_Wizards2()
    {
        var wizards = WizardCollection.Create();
        var expected = new List<(string,int)> {("Harry Potter",2020),("Ron",2020),("Hermione",2020),("Dumbledore",2020)};
        Assert.Equal(expected, Queries.QueryThreeExtensionMethod(wizards));
        
    }
    [Fact]
    public void WizardCollection_With_Reverse_Order()
    {
        var wizards = WizardCollection.Create();
        var expected = new List<string> {"J.K Rowling Harry Potter", "J.K Rowling Ron", "J.K Rowling Hermione"};
        Assert.NotEqual(expected, Queries.QueryFourExtensionMethod(wizards));
        
    }

}
