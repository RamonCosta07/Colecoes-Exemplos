using System;
using System.Collections.Generic;
using ColeçõesGenéricasExemplo.Helper;

namespace ColeçõesGenéricasExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("RJ");
            estados.Add("MG");

            opLista.ImprimirListaString(estados);
            Console.WriteLine("\nApós remover um elemento da lista");
            estados.Remove("RJ");
            opLista.ImprimirListaString(estados);

            string[] array = new string[2] { "SC", "MT" };
            estados.AddRange(array); // Vai adicionar uma coleção de elementos do mesmo tipo na sua própria coleção
            Console.WriteLine("\nApós adicionar elementos do array na lista");
            opLista.ImprimirListaString(estados);

            estados.Insert(2, "AL"); // Adicionar elemento em um indice especifico, e NÃO no final da lista
            Console.WriteLine("\nApós adicionar elemento no indice 2 da lista");
            opLista.ImprimirListaString(estados);

        }
    }
}
