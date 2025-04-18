using System.Text.RegularExpressions;

namespace Exercicio5;

/* Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se 
   * a placa é válida, seguindo o padrão brasileiro válido até 2018:
  - A placa deve ter 7 caracteres alfanuméricos;
  - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
  - Os quatro últimos caracteres são números;

  Ao final, o programa deve exibir Verdadeiro, se a placa for válida, e Falso, caso contrário.*/
internal class Program
{
    static void Main(string[] args)
    {
        string? placa;

        while (true)
        {
            Console.WriteLine("Qual é a placa do carro? (para sair, digite 0 ou pressione Enter)");
            placa = Console.ReadLine();

            if (placa == "0" || string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Saindo...");
                return;
            }
            else
            {
                if (placa.Length == 7)
                {
                    List<char> minhaPlaca = placa.ToList();

                    bool primeiros3ItensLetras = Regex.IsMatch(placa.Substring(0, 3), @"^[a-zA-Z]{3}$");

                    bool ultimos4ItensNumeros = Regex.IsMatch(placa, @"\d{4}$");

                    if (primeiros3ItensLetras && ultimos4ItensNumeros)
                    {
                        Console.WriteLine("Verdadeiro");
                        Console.WriteLine($"\n{placa.ToUpper()} segue os padrões válidos até 2018.\n");
                    }
                    else
                    {
                        Console.WriteLine("Falso");
                        Console.WriteLine($"\n{placa.ToUpper()} não segue os padrões válidos até 2018.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nInforme uma placa válida.\n");
                }
            }
        }
    }
}
