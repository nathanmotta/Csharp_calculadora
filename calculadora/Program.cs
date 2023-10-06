using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora Simples em C#");
        Console.WriteLine("========================");

        // Solicita ao usuário que insira o primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário que insira o segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Exibe as opções de operação para o usuário
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");

        // Solicita ao usuário que escolha uma operação
        Console.Write("Digite o número da operação desejada: ");
        int operacao = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        // Realiza a operação selecionada e exibe o resultado
        switch (operacao)
        {
            case 1:
                resultado = numero1 + numero2;
                break;
            case 2:
                resultado = numero1 - numero2;
                break;
            case 3:
                resultado = numero1 * numero2;
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
}

