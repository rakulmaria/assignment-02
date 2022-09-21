namespace Assignment2.Tests;

using FluentAssertions;

public class StudentTest
{
    [Fact]
    public void Student_ToString_Should_Print_Each_Field_Entry_Of_Student_Object()
    {
        // Arrange
        Student s = new Student{ id = 0, name = "Rakul", surname = "Torgard", startDate = new DateTime(2021,09,01)};

        // Act
        var expected = "Id: 0 Name: Rakul Surname: Torgard Status: Active Start date: 01/09/2021 00.00.00 End date: 01/01/0001 00.00.00 Graduation date: 01/01/0001 00.00.00";

        var actual = s.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void ImmutableStudent_Compared_To_Student_To_String()
    {
        var stu = new Student{id = 2, name = "Erik", surname = "Jakobsen", startDate =new DateTime(2002,2,2),endDate =new DateTime(2002,2,2),graduationDate =new DateTime(2002,2,2)};
        var iStu = new ImmutableStudent{Id =2, GivenName = "Erik",Surname = "Jakobsen", StartDate = new DateTime(2002,2,2),EndDate = new DateTime(2002,2,2),GraduationDate = new DateTime(2002,2,2)};
        Assert.NotEqual(stu.ToString(), iStu.ToString());
    }
    [Fact]
    public void ImmutableStudent_Compared_To_Student_Equals()
    {
        var stu = new Student{id = 2,name = "Erik", surname = "Jakobsen", startDate = new DateTime(2002,2,2),endDate = new DateTime(2002,2,2),graduationDate = new DateTime(2002,2,2)};
        var iStu = new ImmutableStudent{Id = 2,GivenName = "Erik",Surname ="Jakobsen", StartDate= new DateTime(2002,2,2),EndDate =new DateTime(2002,2,2),GraduationDate = new DateTime(2002,2,2)};
        Assert.False(stu.Equals(iStu));
    }
}