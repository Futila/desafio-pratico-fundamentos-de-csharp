
using System.Globalization;

namespace desafio_pratico_fundamentos_de_csharp;

public class Exercicio6
{
    public static void Execute()
    {
        // Obtém a data e hora atual
        DateTime dataAtual = DateTime.Now;

        // Exibe as opções para o usuário
        Console.WriteLine("Escolha o formato de exibição da data/hora:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        // Lê a escolha do usuário
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                // Formato completo
                Console.WriteLine("Data completa: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                // Apenas a data no formato "01/03/2024"
                Console.WriteLine("Data: " + dataAtual.ToString("dd/MM/yyyy"));
                break;
            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine("Hora: " + dataAtual.ToString("HH:mm:ss"));
                break;
            case "4":
                // Data com o mês por extenso
                Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 4.");
                break;
        }
    }
}


