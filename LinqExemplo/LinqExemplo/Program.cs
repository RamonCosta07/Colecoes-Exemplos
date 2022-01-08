using System;
using System.Linq;

namespace LinqExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 100, 1, 4, 7, 18, 66, 129, 66, 4};
            var numerosPares =
                from num in array
                where num % 2 == 0
                orderby num // ordem crescente
                select num;

            var numerosParesMetodo = array.Where(x => x % 2 == 0).OrderBy(x => x).ToList(); // Forma alternativa

            Console.WriteLine("Números pares da Query: " + String.Join(", ", numerosPares));
            Console.WriteLine();
            Console.WriteLine("Números pares do Método: " + String.Join(", ", numerosParesMetodo));
            Console.WriteLine();
            var minimo = array.Min();
            var maximo = array.Max();
            var medio = array.Average();
            var soma = array.Sum(); // Somar todos os elementos do array
            var arrayUnico = array.Distinct().ToArray(); // Retornar um novo array de inteiros sem valores repetidos

            Console.WriteLine($"\nValor Minímo do array {minimo}" +
                $"\nValor Máximo do array: {maximo}" +
                $"\nValor Médio do array: {medio.ToString("F")}" + // Arredondando em duas casas depois da vírgula
                $"\nValor da Soma do array: {soma}" +
                $"\nArray Original: {string.Join(", ", array)}" +
                $"\nArray sem valores repetidos: { string.Join(" ,", arrayUnico)}");
        }
    }
}
