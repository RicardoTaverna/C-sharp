internal class Program
{

    class Aluno
    {
        public string nome;
        public int idade;
        public int serie;

        public void RetornoConsole()
        {
            Console.WriteLine($"O aluno {nome} tem {idade} e esta na {serie} serie");
        }

    }

    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();

        aluno1.nome = "Joao";
        aluno1.idade = 13;
        aluno1.serie = 6;

        aluno1.RetornoConsole();
        
    }
}