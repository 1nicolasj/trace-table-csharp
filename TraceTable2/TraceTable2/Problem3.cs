using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem3 : CalculadoraFutureValue
    {
        public static void Run()
        {
            double valorPresente, taxaJuros, periodo;
            char mesOuAno;
            DateTime dataFinal;
            int totalDias;
            SolicitarDadosInvestimento(out valorPresente, out taxaJuros, out periodo, out mesOuAno, out dataFinal, out totalDias);

            double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, periodo);
            Console.WriteLine($"O valor futuro é: R$ {valorF:F2}");
        }
    }
}
