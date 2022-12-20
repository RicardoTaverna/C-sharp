internal partial class Program
{
    private static void Main(string[] args)
    {
        const double valor = 20.232;
        // uma casa decmal
        System.Console.WriteLine(valor.ToString("F1"));
        // currency
        System.Console.WriteLine(valor.ToString("C"));
        // porcentagem
        System.Console.WriteLine(valor.ToString("P"));
    }
}