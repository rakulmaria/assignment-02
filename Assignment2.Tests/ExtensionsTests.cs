namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void URI_Starts_With_HTTP_Return_True()
    {
        var link = new Uri("https://www.tutlane.com/tutorial/csharp/csharp-stringbuilder");
        Assert.True(Extensions.isSecure(link));
    }
    [Fact]
    public void URI_Starts_With_HTTP_Return_False()
    {
        var link = new Uri("http://www.utunis.rnu.tn");
        Assert.False(Extensions.isSecure(link));
    }
    [Fact]
    public void WordCount_Given_Text_Returns_15()
    {
        var text = "starting test execution, please wait. A total of 1 test files matched the specified pattern. Microsoft";
        Assert.Equal(15,Extensions.WordCount(text));
    }
    [Fact]
    public void WordCount_Given_Text_Returns_12()
    {
        var text = ".Tests.dll (.NETCoreApp,Version=v6.0)Microsoft (R) Test Execution Command Line Tool Version";
        Assert.Equal(12,Extensions.WordCount(text));
    }
    [Fact]
    public void Leapyear_Return_leapyears()
    {
        var intlist = new int[] {4,400,1600,1800,2200,2000};
        Assert.Equal(new List<int> {4,400,1600,2000},Extensions.Leapyear(intlist));
    }
}
