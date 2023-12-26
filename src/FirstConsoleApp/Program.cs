namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine($"Welcome{Environment.NewLine}What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:D} at {currentDate:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}