namespace Calculator.UnitTests;

public class TestSubtraction
{
    [Fact]
    public void Subtraction_PassingTest()
    {
        Assert.Equal(0, Calculator.Subtract(2,2));
    }

    [Fact]
    public void Subtraction_FailingTest()
    {
        Assert.Equal(5, Calculator.Subtract(2,2));
    }

    [Theory]
    [InlineData(2, 2)]
    public void Subtraction_Multiple(int x, int y)
    {
        var answer = x - y;
        var actual = Calculator.Subtract(x, y);
        
        Assert.Equal(answer, actual);
    }
}