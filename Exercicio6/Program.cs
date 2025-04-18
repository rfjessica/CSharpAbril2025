using System.Globalization;

namespace Exercicio6;

/* Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos). 
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas. 
    - A data com o mês por extenso.*/

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Qual é a data de hoje?");

        DateTime dt = DateTime.Now;
        string data = dt.ToLongDateString();
        string hora = dt.ToLongTimeString();
        Console.WriteLine($"Hoje é {data}, {hora}.");

        DateTime hoje = DateTime.Today;
        Console.WriteLine("\n" + hoje.ToString("dd/MM/yyyy"));
        Console.WriteLine("\n" + hora);
        Console.WriteLine("\n" + hoje.ToString("dd/MMMM/yyyy"), new CultureInfo("pt-BR"));
    }
}
