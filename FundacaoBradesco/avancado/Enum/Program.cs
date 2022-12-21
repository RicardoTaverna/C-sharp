internal partial class Program
{
    public enum Genero {Filme, Serie, Documentario}

    public class Filme
    {
        public string nome;
        public Genero tipoVideo;
    }

    private static void Main(string[] args)
    {
        int cod = (int)Genero.Serie;
        Console.WriteLine(cod);
    }
}