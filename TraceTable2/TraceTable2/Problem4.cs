using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem4 : CalculadoraFutureValue
    {
        public static void Run()
        {
            //passando informações do problema 4
            double valorPresente = 2000;
            double taxaJuros = 2;
            int periodoMes = 6;
            double rendLiquido = 0;
            double rendAcumulada = valorPresente + rendLiquido;
            int mesResgate = 5;
            double valorResgate = 1000;


            CalculadoraFutureValue.MostrarTabelaRendimentoComResgate(valorPresente, taxaJuros, periodoMes, mesResgate, valorResgate);
        }
    }
}
