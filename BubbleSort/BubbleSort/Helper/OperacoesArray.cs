using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort.Helper
{
    class OperacoesArray
    {
        public void ordenarBubbleSort(ref int[] array) // Não irá passar um novo array ao retornar, irá trabalhar com a mesma
            //referência desse array
        {
            /* Temp vai servir para que não
             * percamos a informação do valor anterior
             * ao realizar a troca
             */
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++) // Se não tiver o -1, ao chegar no fim do array ele vai tentar
                    //comparar com o próximo valor. Valor esse que não existe, logo haverá um erro
                {
                    if (array[j] > array[j + 1]) // se o elemento atual é > do que o próximo
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    } 
                }
            }
        }

        public void imprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
