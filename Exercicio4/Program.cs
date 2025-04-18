namespace Exercicio4;

/* Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade 
    * de caracteres que a palavra inserida tem.
    * Você pode fazer uma verificação e incrementar o contador apenas se for um caractere, 
    * ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.*/

internal class Program
{
    static void Main(string[] args)
    {
        string? entrada;

        while (true)
        {
            Console.WriteLine("Olá! Escreva algo.\nPara sair, digite 0 ou pressione Enter.");
            entrada = Console.ReadLine();

            if (!string.IsNullOrEmpty(entrada) && (entrada != "0"))
            {
                if (entrada.Count() > 1)
                {
                    entrada = entrada.Replace(" ", "");
                    Console.WriteLine($"{entrada.Count()} caracteres.\n");
                }
                else
                {
                    Console.WriteLine($"{entrada.Count()} caracter.\n");
                }
            }
            else
            {
                Console.WriteLine("Saindo...");
                return;
            }
        }
    }
}
