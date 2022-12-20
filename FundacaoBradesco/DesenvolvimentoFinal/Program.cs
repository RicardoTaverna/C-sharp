internal partial class Program
{
    private static void Main(string[] args)
    {   
        bool opcao = true;

        Console.WriteLine("Ola, vou realizar a soma de numeros que voce deseja ate voce parar.");

        System.Console.WriteLine("Digite o valor inicial: ");
        float.TryParse(Console.ReadLine(), out float inicial);

        while (opcao == true)
        {
            System.Console.WriteLine("Digite o numero a ser somado: ");
            float.TryParse(Console.ReadLine(), out float n1);
            inicial = inicial + n1;

            System.Console.WriteLine("A soma ate o momento é {0}", inicial);
            System.Console.WriteLine("Deseja parar o codigo? 1 - sim | 2 - nao");
            int.TryParse(Console.ReadLine(), out int saida);

            switch(saida)
            {
                case 1:
                    System.Console.WriteLine("Saindo do codigo...");
                    opcao = false;
                    break;
                
                case 2:
                    System.Console.WriteLine("Continuando a soma");
                    break;
                
                case 3:
                    System.Console.WriteLine("Opcao invalida, continuando a soma...");
                    break;
            }

        }
    }
}