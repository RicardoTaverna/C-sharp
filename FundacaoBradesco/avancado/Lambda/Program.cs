internal partial class Program
{
    private static void Main(string[] args)
    {

        Action apresentaConsole = () =>
        {
            Console.WriteLine("Hello, World!");
        };
        apresentaConsole();

        Func<int> sorteio = () =>
        {
            Random random = new Random();
            return random.Next(1,10);
        };
        System.Console.WriteLine(sorteio());

        
    }
}