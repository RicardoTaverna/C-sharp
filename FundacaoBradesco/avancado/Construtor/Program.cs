class Carro
{
    public string nome;
    public string marca;
    public double potencia;

    // Construtor
    public Carro(string nome, string marca, double potencia)
    {
        this.nome = nome;
        this.marca = marca;
        this.potencia = potencia;
    }

    // Construtor vazio
    public Carro(){}
}

internal partial class Program
{
    private static void Main(string[] args)
    {
        var carro = new Carro();
        carro.nome = "Hilux";
        carro.marca = "toyota";
        carro.potencia = 3.1;
        System.Console.WriteLine($"{carro.nome} - {carro.marca} - {carro.potencia}");

        Carro carro2 = new Carro(nome: "Celta", marca: "Chevrolet", potencia: 1.0);
        System.Console.WriteLine($"{carro2.nome} - {carro2.marca} - {carro2.potencia}");


    }
}