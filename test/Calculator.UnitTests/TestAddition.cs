namespace Calculator.UnitTests;

public class TestAddition
{
    
    [Fact]
    public void Addition_PassingTest()
    {
        Assert.Equal(4, Calculator.Add(2,2));
    }

    [Fact]
    public void Addition_FailingTest()
    {
        Assert.Equal(5, Calculator.Add(2,2));
    }
}