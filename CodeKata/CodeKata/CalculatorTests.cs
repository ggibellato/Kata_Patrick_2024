namespace CodeKata;

public class UnitTest1
{
    [Theory]
    [InlineData(1,1,2)]
    [InlineData(2,3,5)]
    [InlineData(7,2,9)]
    public void AddTwoNumbers_Test(int number1, int number2, int result)
    {
        Assert.Equal(result, Calculator.AddTwoNumbers(number1, number2));
    }
}