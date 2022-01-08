using System;

namespace ExemploColeções
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exemplos de utilizações de coleções
             * em C#
             */

            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 12;
            arrayInteiros[1] = 24;
            arrayInteiros[2] = int.Parse("36"); // Podemos converter uma string para int, para ser aceita no array

            Console.WriteLine("Percorrendo array pelo Foreach");
            foreach(var array in arrayInteiros)
            {
               Console.WriteLine($"{array}");
            }

            Console.WriteLine("\nPercorrendo array pelo For");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine($"{i + 1}° Indice = {arrayInteiros[i]}");
            }

            Console.WriteLine("\nCriando um Array Multidimensional (Matriz)");
            int[,] matriz = new int[4, 2]
            {
                {8, 8},
                {4, 4},
                {2, 3},
                {5, 6}
            };

            for (int i = 0; i < matriz.GetLength(0); i++) // GetLenght irá pegar a quantidade de linhas do Array
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // Irá percorrer as colunas
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

        }
    }
}
