public class Professor
{
    protected readonly float salarioMaximo;
    float salarioAtual;

    public Professor(float salarioMaximo)
    {
        this.salarioMaximo = salarioMaximo;
    }

    protected float ModificaSalario(float modf)
    {
        float novoSalario = this.salarioAtual + modf;

        if(novoSalario < 0)
        {
            this.salarioAtual = 0;
        }
        else if (novoSalario > this.salarioMaximo)
        {
            this.salarioAtual = this.salarioMaximo;
        }
        else 
        {
            this.salarioAtual = novoSalario;
        }

        return this.salarioAtual;
    }

    public float AumentaSalario()
    {
        return ModificaSalario(+500);
    }

    public float DiminuiSalario()
    {
        return ModificaSalario(-500);
    }

}


internal class Program
{
    //Herança
    public class Prof : Professor
    {
        public Prof() : base(1400){}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Professor 1: ");
        Prof prof1 = new Prof();
        System.Console.WriteLine(prof1.AumentaSalario());
        System.Console.WriteLine(prof1.AumentaSalario());
        System.Console.WriteLine(prof1.AumentaSalario());
    }
}