
namespace desafio_pratico_fundamentos_de_csharp;

public class Exercicio3
{
    public static void Execute()
    {
        // Declaração dos valores
        double valor1 = 2.5;
        double valor2 = 2.5;

        // Soma
        double soma = valor1 + valor2;
        Console.WriteLine("Soma: " + soma);

        // Subtração
        double subtracao = valor1 - valor2;
        Console.WriteLine("Subtração: " + subtracao);

        // Multiplicação
        double multiplicacao = valor1 * valor2;
        Console.WriteLine("Multiplicação: " + multiplicacao);

        // Divisão (com verificação de divisão por zero)
        if (valor2 != 0)
        {
            double divisao = valor1 / valor2;
            Console.WriteLine("Divisão: " + divisao);
        }
        else
        {
            Console.WriteLine("Divisão: Erro - Divisão por zero!");
        }

        // Média
        double media = (valor1 + valor2) / 2;
        Console.WriteLine("Média: " + media);
    }
}

