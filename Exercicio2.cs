
namespace desafio_pratico_fundamentos_de_csharp;

public class Exercicio2
{
    public static void Execute()
    {
        Console.WriteLine("Digite seu nome: ");

        string name = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");

        string surname = Console.ReadLine();

        string userfullname = $"{name} {surname}";



        Console.WriteLine("Seu nome completo é: " + userfullname);
    }
}
