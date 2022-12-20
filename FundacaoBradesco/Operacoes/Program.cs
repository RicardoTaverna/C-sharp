internal partial class Program
{
    private static void Main(string[] args)
    {
        // double nota1 = 8.0;
        // double nota2 = 9.0;

        // System.Console.WriteLine("Nota maior que 7?: {0}", nota1 > 7.0);
        // System.Console.WriteLine("Tirou 10?: {0}", nota2 == 10.0);

        // System.Console.WriteLine("Digite sua nota: ");
        // double.TryParse(Console.ReadLine(), out double nota);

        // System.Console.WriteLine("Nota maior que 7?: {0}", nota > 7.0);
        // System.Console.WriteLine("Tirou 10?: {0}", nota == 10.0);

        var n1 = 5;
        var n2 = 9;
        var n3 = 10;

        if (n1 < n2)
        {
            System.Console.WriteLine(n1 + n2);
        }
        if (n3 < n2)
        {
            System.Console.WriteLine(n3 + n2);
        }

        System.Console.WriteLine("Qual nota voce da para o prato? 0, 5 ou 10");
        int.TryParse(Console.ReadLine(), out int nota);

        switch (nota)
        {
            case 0:
                System.Console.WriteLine("Comida muito ruim!");
                break;
            case 5:
                System.Console.WriteLine("Comida razoavel.");
                break;
            case 10:
                System.Console.WriteLine("Comida muito boa");
                break;
            default:
                System.Console.WriteLine("Nota inexistente");
                break;
        }

    }
}