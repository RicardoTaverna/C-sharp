internal partial class Program
{

    public struct PontoS
    {
        public int x;
        public int y;
    }

    public class PontoC
    {
        public int x;
        public int y;
    }

    private static void Main(string[] args)
    {
        PontoS ponto1 = new PontoS{ x=5, y=3};
        PontoS ponto2 = ponto1;
        ponto1.x = 3;
        Console.WriteLine($"Ponto1 x: {ponto1.x}");
        System.Console.WriteLine($"Ponto2 x: {ponto2.x}");

        PontoC ponto3 = new PontoC{ x=6, y=9 };
        PontoC ponto4 = ponto3;
        ponto3.x = 3;
        Console.WriteLine($"Ponto3 x: {ponto3.x}");
        System.Console.WriteLine($"Ponto4 x: {ponto4.x}");
    }
}