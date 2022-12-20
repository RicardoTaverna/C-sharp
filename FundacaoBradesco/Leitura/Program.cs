internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome?");
        String nome = Console.ReadLine();

        System.Console.WriteLine("Quantos anos voce tem?");
        int idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
    }
}