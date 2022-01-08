using System;
using ClasseArray.Helper;

namespace ClasseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 10, 3, 120, 13, 6 };
            Console.WriteLine("Array Inicial: ");
            op.ImprimirArray(array);
            Console.WriteLine();

            Console.WriteLine("Array Após Ser Ordenado: ");
            op.Ordenar(ref array);
            op.ImprimirArray(array);
            Console.WriteLine();

            Console.WriteLine("Copiando um Array Para outro com a Classe Array");
            int[] arrayCopia = new int[10];
            Console.WriteLine();
            Console.WriteLine("Array Antes da Cópia: ");
            op.ImprimirArray(arrayCopia);
            Console.WriteLine("\nArray Depois de ser Copiado: ");
            op.Copiar(ref array, ref arrayCopia);
            op.ImprimirArray(arrayCopia);

            Console.WriteLine("\n");
            Console.WriteLine("Verificando se o elemento existe no array:");
            int valorBuscado = 120;
            bool existe = op.Existe(array, valorBuscado);
            if (existe)
            {
                Console.WriteLine($"O valor {valorBuscado} existe no Array");
            } else
            {
                Console.WriteLine($"O valor {valorBuscado} não existe no Array");
            }

            Console.WriteLine("\nVerificar Se Todos os elementos são maiores do que 0 no arrayCopia: ");
            var elemento = 13;
            bool maior = op.TodosMaiorQue(arrayCopia, elemento);
            if (maior)
            {
                Console.WriteLine("Todos os elementos do array são maiores do que {0}", elemento);
            }
            else
            {
                Console.WriteLine("Há elementos que não são maiores do que {0} no array", elemento);
            }

            Console.WriteLine();
            Console.WriteLine("Buscar um elemento no array: ");
            int valorAchado = op.ObterValor(array, elemento);
            if(valorAchado > 0)
            {
                Console.WriteLine($"Encontrei o valor {elemento} no array");
            } else
            {
                Console.WriteLine($"Não encontrei o valor {elemento} no array");
            }
            
            Console.WriteLine();
            int indice = op.ObterIndice(array, elemento);
            if(indice > -1)
            {
                Console.WriteLine("O indice do elemento {0} é: {1}", elemento, indice);
            } else
            {
                Console.WriteLine("Valor não existe no array!");
            }

            Console.WriteLine($"\nCapacidade atual do array: {array.Length}");
            op.RedimensionarArray(ref array, array.Length * 2);
            Console.WriteLine($"Capacidade atual do array após ele redimensionar: {array.Length}\n");

            string[] arrayString = op.ConverterParaArrayString(array);
            arrayString[5] = "Palavra";
            Console.WriteLine("Elementos em formar de string no array string após ser copiado do array: ");
            foreach(var i in arrayString)
            {
                Console.Write($"{i}  ");
            }

        }
    }
}
