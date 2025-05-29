using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem8 : CalculadoraFutureValue
    {
        public static void Run()
        {
            //passando as informações do problema 8
            double valorPresente = 1000;
            double taxaJuros = 3;
            char mesOuAno = 'm';
            int totalDias = 255; // total de dias para 8 meses e 10 dias
            DateTime dataInicial = DateTime.Now;
            CalculadoraFutureValue.MostrarTabelaRendimentoDiario(valorPresente, taxaJuros, mesOuAno, totalDias, dataInicial);
        }
    }
}
