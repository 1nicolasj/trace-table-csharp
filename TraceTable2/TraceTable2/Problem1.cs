using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem1 : CalculadoraFutureValue
    {
        public static void Run()
        {
            double valorPresente, taxaJuros;
            double periodoMes;
            SolicitarDadosInvestimento(out valorPresente, out taxaJuros, out periodoMes);

            double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, periodoMes);
            Console.WriteLine($"O valor futuro é: R$ {valorF:F2}");
        }
    }
}
