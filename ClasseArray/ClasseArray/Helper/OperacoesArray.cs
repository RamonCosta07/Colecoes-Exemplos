
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseArray.Helper
{
    class OperacoesArray
    {
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array); // concatenar o array com ", "
            Console.WriteLine(linha);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor) // Verificar se um elemento existe no vetor
        {
            /* O elemento representa cada elemento do array,
             * onde será verificado se o Elemento é igual
             * ao valor que está sendo buscado no array 
             */
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor); //Verificar se todos os elementos são maiores que valor
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor); // Caso não encontre o valor buscado irá retornar o indice -1
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho); // Muda a capacidade do Array
            /* Na prática ele cria um novo array, com os mesmo
             * elementos do array indicado, copiando para ele,
             * atribuindo um novo tamanho a ele a ser indicado
             */
        }

        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString()); // converter os elementos do array em string
        }
    }
}
