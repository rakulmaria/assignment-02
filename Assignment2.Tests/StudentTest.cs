namespace Assignment2.Tests;

using FluentAssertions;

public class StudentTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        Student s = new Student{ id = 0, name = "Rakul", surname = "Torgard", startDate = new DateTime(2021,9,1)};

        // Act
        var expected = "Name: Rakul \nSurname: Torgard \nStatus: Active \nStart Date: 2021/9/1 End date: null \nGraduation Date: null";
        var actual = s.ToString();

        // Assert
        expected.Should().Be(actual);
    }
}