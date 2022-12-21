public class Carro
{
    private string nome;
    private string marca;
    private double potencia;

    // Construtor
    public Carro(string nome, string marca, double potencia)
    {
        this.nome = nome;
        this.marca = marca;
        this.potencia = potencia;
    }

    // Construtor vazio
    public Carro(){}

    public string GetMarca()
    {
        return marca;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}