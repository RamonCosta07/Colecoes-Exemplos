using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeçõesGenéricasExemplo.Helper
{
    class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Indice: {i}. Valor: {lista[i]}");
            }
        }
    }
}
