using System;

namespace DesafioDiamante.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        int numeroImpar = 21;
        string caractere = "X";

        for (int i = 1; i <= numeroImpar; i += 2)
        {
            int espacoEmBranco = (numeroImpar - i) / 2;
            for (int j = 0; j < espacoEmBranco; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(caractere);
            }
            Console.WriteLine();
        }

        for (int i = numeroImpar - 2; i >= 1; i -= 2)
        {
            int espacoEmBranco = (numeroImpar - i) / 2;
            for (int j = 0; j < espacoEmBranco; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(caractere);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
