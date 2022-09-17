namespace StudentClassLibrary.Tests;

public class QueriesTests
{
    [Fact]
    public void Test1_New_Student_To_String()
    {
        var stu = new Student(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2002,2,2),new DateTime(2002,2,2));
        Assert.Equal("Id: 2, Givenname: Erik, Surname: Jakobsen, Status: Graduated, Start date: 02/02/2002 00.00.00, End date: 02/02/2002 00.00.00, Graduation date: 02/02/2002 00.00.00",stu.ToString());
    }
    [Fact]
    public void New_Student_Should_Return_Active()
    {
        var stu = new Student(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2024,2,2),new DateTime(2024,2,2));
        var status = stu.Status;
        Assert.Equal("Active",status.ToString());   
    }
    [Fact]
    public void New_Student_Should_Return_Dropout()
    {
        var stu = new Student(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2010,2,2),new DateTime(2024,2,2));
        var status = stu.Status;
        Assert.Equal("Dropout",status.ToString());
    }
    [Fact]
    public void ImmutableStudent_Compared_To_Student_To_String()
    {
        var stu = new Student(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2002,2,2),new DateTime(2002,2,2));
        var iStu = new ImmutableStudent(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2002,2,2),new DateTime(2002,2,2));
        Assert.Equal(stu.ToString(), iStu.ToString());
    }
    [Fact]
    public void ImmutableStudent_Compared_To_Student_Equals()
    {
        var stu = new Student(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2002,2,2),new DateTime(2002,2,2));
        var iStu = new ImmutableStudent(2,"Erik","Jakobsen", new DateTime(2002,2,2),new DateTime(2002,2,2),new DateTime(2002,2,2));
        Assert.False(stu.Equals(iStu));
    }
}
