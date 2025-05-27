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
            double valorPresente, taxaJuros;
            int periodoAno;
            SolicitarDadosInvestimento(out valorPresente, out taxaJuros, out periodoAno);

            double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, periodoAno);
            Console.WriteLine($"O valor futuro é: R$ {valorF:F2}");
        }
    }
}
