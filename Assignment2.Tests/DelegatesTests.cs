namespace Assignment2.Tests;


public class DelegatesTests
{
    [Fact]
    public void Delegate_Reverse_Order()
    {
        var text = "abcdefg";
        Delegates.PrintReverse(text);
        
    }
    [Fact]
    public void Delegate_Product()
    {
        decimal product = 200;
        Assert.Equal(product,Delegates.returnProduct(10,20)); 
    }
    [Fact]
    public void Delegate_Numerically_Equal_REturn_True()
    {
        Assert.True(Delegates.numericallyEqual(20,"0020")); 
    }
}
