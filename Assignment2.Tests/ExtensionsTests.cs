namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_Given_List_Of_List_Returns_One_Combined_List()
    {
        // Arrange
        IEnumerable<int>[] listOfLists =
        {
            new List<int>() { 1, 2, 3, 3 },
            new List<int>() { 4, 5, 6, 7 },
            new List<int>() { 8, 9 }
        };

        var expected = new[] {1, 2, 3, 3, 4, 5, 6, 7, 8, 9};

        // Act
        var actual= Extensions.Flatten(listOfLists);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divisible_Given_Array_Returns_List_Of_Numbers_Greater_Than_47_And_Divisible_By_7()
    {
        // Arrange
        var data = new[] {1, 2, 7, 3, 50, 51, 52, 70, 462};

        var expected = new[] {70, 462};

        // Act
        var actual= Extensions.Divisible(data);

        // Assert
        Assert.Equal(expected, actual);
    }
}
