public class Mensagem
{
    private string texto;

    public void Exibir(){
        System.Console.WriteLine(this.texto);
    }

    public string getTexto()
    {
        return this.texto;
    }

    public void setTexto(string texto)
    {
        this.texto = texto;
    }
}

internal partial class Program
{
    private static void Main(string[] args)
    {
        Mensagem txt1;

        txt1 = new Mensagem();
        txt1.setTexto("Curso avançado de C#");
        txt1.Exibir();
    }
}