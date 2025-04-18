namespace Exercicio3;
/* Crie um programa com 2 valores do tipo double`já declarados que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.
    
    💡 Você pode ir além e permitir que o usuário insira dois números aleatórios!*/

internal class Program
{
    public static void Matematica(double x, double y)
    {
        Console.WriteLine($"{x} + {y} = {OperacoesMatematicas.Adicao(x, y)}");
        Console.WriteLine($"{x} - {y} = {OperacoesMatematicas.Subtracao(x, y)}");
        Console.WriteLine($"{x} * {y} = {OperacoesMatematicas.Multiplicacao(x, y)}");
        OperacoesMatematicas.Divisao(x, y);
        Console.WriteLine($"Média de {x} e {y} = {OperacoesMatematicas.CalcularMedia(x, y)}");
    }

    public static string ConvertePontoParaVirgula(string x)
    {
        if (x.Contains('.'))
        {
            x = x.Replace(".", ",");
        }
        return x;
    }

    public static void DigiteNovamente(string? x)
    {
        Console.WriteLine("Tente novamente.\nInsira um valor decimal válido:");
    }

    static void Main(string[] args)
    {
        double v1 = 7.5, v2 = 0.75;

        Matematica(v1, v2);

        string? n1, n2;
        Console.WriteLine("\nInforme o primeiro valor decimal: ");
        n1 = Console.ReadLine();

        while (string.IsNullOrEmpty(n1))
        {
            DigiteNovamente(n1);
            n1 = Console.ReadLine();
        };

        n1 = ConvertePontoParaVirgula(n1);

        Console.WriteLine("\nAgora, digite outro valor decimal: ");
        n2 = Console.ReadLine();
        Console.WriteLine("");

        while (string.IsNullOrEmpty(n2))
        {
            DigiteNovamente(n2);
            n2 = Console.ReadLine();
        };

        n2 = ConvertePontoParaVirgula(n2);
        var num1 = Convert.ToDouble(n1);
        var num2 = Convert.ToDouble(n2);

        Matematica(num1, num2);
    }
}
