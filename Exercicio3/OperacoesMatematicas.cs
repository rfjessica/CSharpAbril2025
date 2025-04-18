namespace Exercicio3;

public static class OperacoesMatematicas
{
    public static double Adicao(double n1, double n2) => n1 + n2;
    public static double Subtracao(double n1, double n2) => n1 - n2;
    public static double Multiplicacao(double n1, double n2) => n1 * n2;

    public static void Divisao(double n1, double n2)
    {
        if (n2 != 0)
        {
            double div = n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {div}");
        }
        else
            Console.WriteLine($"Impossível dividir {n1} por zero.");
    }
    public static double CalcularMedia(double n1, double n2) => (n1 + n2) / 2;
}
