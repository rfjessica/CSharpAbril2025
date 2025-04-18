namespace Exercicio1;

/* Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas 
 personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!*/
internal class Program
{ 
    static void Main(string[] args)
    {
        string? nome, genero;

        Console.WriteLine("Qual é seu nome? ");

        nome = Console.ReadLine();

        Console.WriteLine("\nQual é seu gênero? Digite M ou F: ");

        genero = Console.ReadLine();

        if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(genero))
        {
            Console.WriteLine("\nOlá! Boas vindas!");
        }
        else
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (string.IsNullOrEmpty(genero))
                {
                    Console.WriteLine($"\nOlá, {nome}! Boas vindas!");
                }
                else
                {
                    if (genero.Equals("m") || genero.Equals("f"))
                    {
                        genero = genero.ToUpper();
                    }
                    else
                    {
                        if (!genero.Equals("M") && !genero.Equals("F"))
                        {
                            Console.WriteLine($"\nOlá, {nome}! Boas vindas!");
                        }
                    }

                    switch (genero)
                    {
                        case "F":
                            Console.WriteLine($"\nOlá, {nome}! Seja muito bem-vinda!");
                            break;
                        case "M":
                            Console.WriteLine($"\nOlá, {nome}! Seja muito bem-vindo!");
                            break;
                    }
                }
            }
        }
    }
}
