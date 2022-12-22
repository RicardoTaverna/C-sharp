delegate double BinaryNumericOperatio(double n1, double n2);

internal partial class Program
{

    class Calculadora
    {
        public static double Max(double x, double y)
        {
            if(x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public static double soma(double x, double y)
        {
            return x + y;
        }
    }

    private static void Main(string[] args)
    {

        double a = 10;
        double b = 30;

        BinaryNumericOperatio operacao = Calculadora.soma;
        System.Console.WriteLine(operacao(a, b));

    }
}