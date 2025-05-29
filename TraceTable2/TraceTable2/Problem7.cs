using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem7 : CalculadoraFutureValue
    {
        public static void Run()
        {
            //passando as informações do problema 7
            double valorPresente = 1000;
            double taxaJuros = 3;
            char mesOuAno = 'm';
            int totalDias = 255; //total de dias para 8 meses e 10 dias
            int diaDoResgate = 5 * 30; //dia do resgate no mes 5
            double valorResgate = 1000;
            DateTime dataInicial = DateTime.Now;
            CalculadoraFutureValue.MostrarTabelaRendimentoDiarioComResgate(valorPresente, taxaJuros, mesOuAno, totalDias, diaDoResgate, valorResgate, dataInicial);
        }
    }
}