
namespace desafio_pratico_fundamentos_de_csharp;

public class Exercicio4
{
   
    public static void Execute()
    {
        
        Console.WriteLine("Digite uma ou mais palavras:");
        string input = Console.ReadLine();

        
        int contadorCaracteres = 0;

      
        foreach (char caractere in input)
        {
        
            if (!char.IsWhiteSpace(caractere))
            {
                contadorCaracteres++;
            }
        }

       
        Console.WriteLine("Número total de caracteres (sem espaços): " + contadorCaracteres);
    }
}

