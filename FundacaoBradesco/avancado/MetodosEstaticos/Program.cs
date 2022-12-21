internal partial class Program
{
    public static int somar(int x, int y)
    {
        return x + y;
    }

    public int multiplicar(int x, int y)
    {
        return x * y;
    }

    private static void Main(string[] args)
    {   
        var result = Program.somar(3, 3);
        Console.WriteLine("A soma é igual a: {0}", result);

        Program calc = new Program();
        Console.WriteLine(calc.multiplicar(3, 4));
    }
}