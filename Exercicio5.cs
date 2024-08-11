
using System.Text.RegularExpressions;

namespace desafio_pratico_fundamentos_de_csharp;

using System.Text.RegularExpressions;

public class Exercicio5
{

    public static void Execute()
    {
       
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine()!;

        if(placa is not null)
        {
            bool placaValida = ValidarPlaca(placa);


            Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");

        }

       
    }

    static bool ValidarPlaca(string placa)
    {
        
        if (placa.Length != 7)
        {
            return false;
        }

   
        string padrao = @"^[a-zA-Z]{3}[0-9]{4}$";
        return Regex.IsMatch(placa, padrao);
    }
}


