using System;
using System.Collections.Generic;

namespace PilhaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaLivros = new Stack<string>(); // criando uma pilha
            pilhaLivros.Push("As Crônicas de Nárnia");
            pilhaLivros.Push("Harry Potter");
            pilhaLivros.Push("A Bussúla de Ouro");

            Console.WriteLine($"Livros a serem lidos: {pilhaLivros.Count}\n\n");
            while(pilhaLivros.Count > 0)
            {
                Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
                Console.WriteLine($"{pilhaLivros.Pop()} lido\n");
            }
            Console.WriteLine($"\nLivros a serem lidos: {pilhaLivros.Count}");
        }
    }
}
