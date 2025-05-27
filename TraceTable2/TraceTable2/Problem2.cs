using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem2 : CalculadoraFutureValue
    {
        public static void Run()
        {
            //passando as informações do problema 2
            double valorPresente = 3800;
            double taxaJuros = 1.25;
            int periodoMes = 6;

            CalculadoraFutureValue.MostrarTabelaRendimento(valorPresente, taxaJuros, periodoMes);
        }
    }
}
