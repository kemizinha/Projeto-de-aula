using System;
using System.Globalization;

namespace matrizclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int[,] A = new int[M, M];
            //leitura de a
            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }
            //diagonal principal
            Console.Write("Main Diagonal: ");
            for (int i = 0; i < M; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            //negativos
       
            double soma = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (A[i, j] < 0)
                    {
                        soma++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + soma);


        }
    }
}
