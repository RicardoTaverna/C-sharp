internal partial class Program
{
    public static void Despedida(params string [] alunos)
    {
        foreach(var aluno in alunos)
        {
            System.Console.WriteLine($"Tchau {aluno}, ate a proxima aula");
        }
    }
    private static void Main(string[] args)
    {
        Despedida("Joao", "Thiago", "Antonio");
    }
}