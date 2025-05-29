using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem6 : CalculadoraFutureValue
    {
        public static void Run()
        {
            double valorPresente, taxaJuros, periodo;
            char mesOuAno;
            DateTime dataFinal;
            int totalDias;
            SolicitarDadosInvestimento(out valorPresente, out taxaJuros, out periodo, out mesOuAno, out dataFinal, out totalDias);

            double valorF = CalculadoraFutureValue.CalcularValorFuturoDatas(valorPresente, taxaJuros, mesOuAno, totalDias);
        }
    }
}
