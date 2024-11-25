using System;

namespace atividade10
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Digite um número para calcular o fatorial:");
            if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro não negativo.");
                return;
            }

           
            switch (numero)
            {
                case 0:
                case 1:
                    Console.WriteLine($"O fatorial de {numero} é 1.");
                    break;

                default:
                   
                    long fatorial = 1;
                    for (int i = 2; i <= numero; i++)
                    {
                        fatorial *= i;
                    }
                    Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
                    break;
            }
        }
    }
}

