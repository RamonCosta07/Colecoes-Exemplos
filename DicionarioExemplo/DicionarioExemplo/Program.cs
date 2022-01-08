using System;
using System.Collections.Generic;

namespace DicionarioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>(); // Tipo da chave e do valor, respectivamente 
            estados.Add("SP", "São Paulo"); // Não podemos ter chaves repetidas
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach(KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
            }

            string valorProcurado = "SP";
            Console.Write("\nAcessando um valor pela sua chave: ");
            Console.WriteLine($"{estados[valorProcurado]}");

            Console.WriteLine("\n...Atualizando um valor... ");
            Console.WriteLine($"Valor original: {estados[valorProcurado]}");
            estados[valorProcurado] = "Guarulhos";
            Console.WriteLine($"Valor após ser atualizado: {estados[valorProcurado]}");

            Console.WriteLine($"\nRemovendo o valor: {valorProcurado}");
            estados.Remove(valorProcurado);
            Console.WriteLine("Após o valor ser removido:");
            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}");
            }

            Console.WriteLine("\n...Verificando se uma determinada chave existe no Dicionário...");
            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine($"Encontramos a chave {estadoEncontrado} no Dicionário!");
            } else
            {
                Console.WriteLine($"Chave {valorProcurado} não existe no Dicionário!");
            }
        }
    }
}
