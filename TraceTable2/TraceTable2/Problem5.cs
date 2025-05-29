using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Problem5 : CalculadoraFutureValue
    {
        public static void Run()
        {
            double valorPresente = 3800;
            double taxaJuros = 1.25;
            int periodoMes = 54; //calculado na planilha que o período para alcançar o valor de 7390,61 é de 54 meses

            CalculadoraFutureValue.MostrarTabelaRendimento(valorPresente, taxaJuros, periodoMes);
            Console.WriteLine("Cálculo obtém o valor R$7.390,61 em um período de 54 meses (4,5 anos)");
        }
    }
}
