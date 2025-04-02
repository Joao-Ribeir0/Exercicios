using System;

class Program
{
    static void Main()
    {
        int num;
        do
        {
            Console.WriteLine("Informe um número: ");
        } while (!int.TryParse(Console.ReadLine(), out num));

        SequenciaFibonacci(num);
    }

    static void SequenciaFibonacci(int num)
    {
        if (num == 0 || num == 1)
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci!");
            return;
        }

        int numAnterior = 0;
        int numAtual = 1;
        int numeroSeguinte = numAnterior + numAtual;

        for (int i = 2; numeroSeguinte <= num; i++)
        {
            if (num == numeroSeguinte)  
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci!");
                return;
            }

            numAnterior = numAtual;
            numAtual = numeroSeguinte;
            numeroSeguinte = numAnterior + numAtual;  
        }

        Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci!");
    }
}
