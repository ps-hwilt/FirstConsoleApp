namespace Calculator.UnitTests;

public class TestMultiplication
{
    [Fact]
    public void Multiplication_PassingTest()
    {
        Assert.Equal(4, Calculator.Multiply(2,2));
    }

    [Fact]
    public void Multiplication_FailingTest()
    {
        Assert.Equal(5, Calculator.Multiply(2,2));
    }
}