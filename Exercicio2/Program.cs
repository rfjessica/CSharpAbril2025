namespace Exercicio2;

/* Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário
    e ao final exiba o nome completo.*/
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome: ");

        string? nome = Console.ReadLine();

        Console.WriteLine("\nAgora, digite o sobrenome: ");

        string? sobrenome = Console.ReadLine();

        string nomeCompleto = string.Empty;

        if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(sobrenome))
        {
            nomeCompleto = string.Concat(nome, " ", sobrenome);
            Console.WriteLine($"\n{nomeCompleto}");
        }
        else
        {
            if (string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(sobrenome))
                Console.WriteLine($"\nSobrenome: {sobrenome}");
            else
            {
                if (!string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(sobrenome))
                    Console.WriteLine($"\nNome: {nome}");
                else
                    return;
            }
        }
    }
}
