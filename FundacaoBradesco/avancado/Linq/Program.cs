using System.Linq;

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[] { 4, 5, 6, 7, 8, 9, 10};

        var operacao = numeros.Where( x => x % 2 == 0);
        
        foreach(int x in operacao)
        {
            Console.WriteLine(x);

        }
        
    }
}