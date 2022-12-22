public abstract class Telefone
{
    public abstract string Tipo();
}

public class Xiaomi : Telefone
{
    public override string Tipo()
    {
        return "Note 8 Pro";
    }
}


internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}