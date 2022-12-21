internal partial class LeituraNotas
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo a calculadora de médias! Entre as 3 notas do aluno.");

        System.Console.WriteLine("Digite a primeira nota: ");
        int.TryParse(Console.ReadLine(), out int nota1);

        System.Console.WriteLine("Digite a segunda nota: ");
        int.TryParse(Console.ReadLine(), out int nota2);

        System.Console.WriteLine("Digite a terceira nota: ");
        int.TryParse(Console.ReadLine(), out int nota3);

        double media = (nota1 + nota2 + nota3)/3;

        System.Console.WriteLine("A média do aluno é : {0}", media);

        if (media < 7.0)
        {
            System.Console.WriteLine("Aluno esta de recuperacao");
        }
        else
        {
            System.Console.WriteLine("Aluno aprovado");
        }
    }
}