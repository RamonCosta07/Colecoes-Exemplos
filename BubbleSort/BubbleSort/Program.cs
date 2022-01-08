using BubbleSort.Helper;
using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 9, 4, 29, 3, 5 };
            OperacoesArray op = new OperacoesArray();

            Console.WriteLine("Array Original: ");
            op.imprimirArray(array);
            Console.WriteLine();
            op.ordenarBubbleSort(ref array);
            Console.WriteLine("\nArray Ordenado com Bubble Sort: ");
            op.imprimirArray(array);
            Console.WriteLine();
            
        }
    }
}
