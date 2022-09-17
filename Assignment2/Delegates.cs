namespace Assignment2;

public static class Delegates
{
    public static Action<string> PrintReverse = delegate (string stringInput) {
    char[] charArray = stringInput.ToCharArray();  
    Array.Reverse(charArray);  
    Console.WriteLine(new string(charArray));
    };

    public static Func<decimal,decimal,decimal> returnProduct = (x,y) => x * y;
    
    public static Func<int,string,bool> numericallyEqual = (inputNumber,inputString) => inputNumber == Int32.Parse(inputString)? true:false;
   
    
}
