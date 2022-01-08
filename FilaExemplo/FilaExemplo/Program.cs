using System;
using System.Collections;

namespace FilaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue(); // criação de uma Fila
            fila.Enqueue("Ramon");
            fila.Enqueue("Renan");
            fila.Enqueue("Rafaela");
            fila.Enqueue("Roan");
            Console.WriteLine($"Pessoas na fila: {fila.Count}\n\n");
            while(fila.Count > 0)
            {
                /* Peek retorna a pessoa que está no começo da fila
                 * Mas não remove ela da fila.
                 * Apenas para saber quem é o próximo
                 */
                Console.WriteLine($"Vez de: {fila.Peek()}");
                Console.WriteLine($"{fila.Dequeue()} atendido\n"); // Agora sim ele está sendo removido
            }
            Console.WriteLine($"\nPessoas na fila: {fila.Count}");
        }
    }
}
