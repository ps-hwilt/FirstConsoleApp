namespace Calculator.UnitTests;

public class TestIsEven
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(7)]
    [InlineData(600)]
    public void IsEven_MultipleNums(int num)
    {
        Assert.True(Calculator.IsEven(num));
    }

    [Fact]
    public void IsEven_Passing()
    {
        Assert.Equal(true, Calculator.IsEven(2));
    }
}