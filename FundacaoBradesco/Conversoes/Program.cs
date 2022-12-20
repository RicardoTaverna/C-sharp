internal partial class Program
{
    private static void Main(string[] args)
    {
        // double nota = 8.6;
        // int notaConvertida = (int)nota;
        // Console.WriteLine(notaConvertida);
        System.Console.WriteLine("Digite o numero da sua casa: ");
        string numeroCasa = Console.ReadLine();
        int numero = int.Parse(numeroCasa);
        System.Console.WriteLine("Numero da sua casa: {0}", numero);

        numero = Convert.ToInt32(numeroCasa);
        System.Console.WriteLine(numero);
    }
}