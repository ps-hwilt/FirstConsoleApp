namespace Calculator;

public static class Calculator
{
    static void Main()
    {
        Console.WriteLine("Calc");
    }
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
    public static bool IsEven(int x) => x % 2 == 0;
}